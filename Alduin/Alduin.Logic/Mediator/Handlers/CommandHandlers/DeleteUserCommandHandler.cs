using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Logic.Mediator.Commands;
using Alduin.Shared.Transaction;

namespace Alduin.Logic.Mediator.Handlers.CommandHandlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, TransactionResult>
    {
        private readonly IUserManager _userManager;

        public DeleteUserCommandHandler(IUserManager userManager)
        {
            _userManager = userManager;
        }

        public Task<TransactionResult> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var result = _userManager.Delete(request.UserId);
            return Task.FromResult(result);
        }
    }
}
