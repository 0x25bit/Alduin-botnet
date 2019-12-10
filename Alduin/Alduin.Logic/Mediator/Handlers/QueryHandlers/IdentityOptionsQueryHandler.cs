using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Mediator.Queries;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class IdentityOptionsQueryHandler : IRequestHandler<IdentityOptionsQuery, IList<string>>
    {
        private readonly IOptions<IdentityOptions> _identityOptions;

        public IdentityOptionsQueryHandler(IOptions<IdentityOptions> identityOptions)
        {
            _identityOptions = identityOptions;
        }

        public Task<IList<string>> Handle(IdentityOptionsQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var pwdOptions = _identityOptions.Value.Password;
            var pwdInfo = new List<string>
            {
                $"Password must be at least {pwdOptions.RequiredLength} characters long!"
            };

            if (pwdOptions.RequireDigit)
                pwdInfo.Add("Password must contain a digit!");
            if (pwdOptions.RequireLowercase)
                pwdInfo.Add("Password must contain a lowercase letter!");
            if (pwdOptions.RequireUppercase)
                pwdInfo.Add("Password must contain an uppercase letter!");
            if (pwdOptions.RequireNonAlphanumeric)
                pwdInfo.Add("Password must contain a non-alphanumeric character (;,* etc.)!");

            return Task.FromResult(pwdInfo as IList<string>);
        }
    }
}
