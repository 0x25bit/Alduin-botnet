using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.DTOs;
using Alduin.Logic.Identity;
using Alduin.Logic.Mediator.Commands;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.Mediator.Handlers.CommandHandlers
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, ActionResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppIdentityUserManager _identityUserManager;
        private readonly AppSignInManager _signInManager;

        public LoginCommandHandler(IUnitOfWork unitOfWork, AppIdentityUserManager identityUserManager, AppSignInManager signInManager)
        {
            _unitOfWork = unitOfWork;
            _identityUserManager = identityUserManager;
            _signInManager = signInManager;
        }

        public async Task<ActionResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            _unitOfWork.BeginTransaction();

            var user = await _identityUserManager.FindByNameAsync(request.Email);
            if (user == null)
            {
                return new ActionResult
                {
                    Suceeded = false,
                    ErrorMessages = new List<string> { "E-mail or password is incorrect!" }
                };
            }

            var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, request.RememberMe);
                _unitOfWork.Commit();

                return new ActionResult { Suceeded = true };
            }
            else
            {
                var loginResult = new ActionResult { Suceeded = false };

                if (result.IsLockedOut)
                    loginResult.ErrorMessages.Add("Your account is locked out!");
                else
                    loginResult.ErrorMessages.Add("E-mail or password is incorrect!");

                _unitOfWork.Rollback();

                return loginResult;
            }
        }
    }
}
