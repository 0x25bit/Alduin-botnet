using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;


namespace Alduin.Logic.Identity
{
    public class AppIdentityUserManager : UserManager<AppIdentityUser>
    {
        private readonly CancellationToken _cancellationToken;
        private readonly IUserClaimRepository _userClaimRepository;

        public AppIdentityUserManager(IUserStore<AppIdentityUser> store,
            IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<AppIdentityUser> passwordHasher,
            IEnumerable<IUserValidator<AppIdentityUser>> userValidators,
            IEnumerable<IPasswordValidator<AppIdentityUser>> passwordValidators,
            ILookupNormalizer keyNormalizer, AppIdentityErrorDescriber errors,
            IServiceProvider services, ILogger<UserManager<AppIdentityUser>> logger,
            IUserClaimRepository userClaimRepository)
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _cancellationToken = services?.GetService<IHttpContextAccessor>()?.HttpContext?.RequestAborted ?? CancellationToken.None;
            _userClaimRepository = userClaimRepository;
        }

        protected override CancellationToken CancellationToken => _cancellationToken;

        public override async Task<IdentityResult> ResetPasswordAsync(AppIdentityUser user, string token, string newPassword)
        {
            var result = await base.ResetPasswordAsync(user, token, newPassword);
            return result;
        }

        public override async Task<IdentityResult> ChangePasswordAsync(AppIdentityUser user, string currentPassword, string newPassword)
        {
            var result = await base.ChangePasswordAsync(user, currentPassword, newPassword);
            return result;
        }

        public async Task ReplaceRoleClaims(AppIdentityUser user, IList<Role> newRoles)
        {
            var userClaims = _userClaimRepository.GetSpecificClaimsByUserId(user.Id, ClaimTypes.Role);
            foreach (var userClaim in userClaims)
            {
                var claim = new AppIdentityUserClaim
                {
                    UserId = user.Id,
                    ClaimType = userClaim.ClaimType,
                    ClaimValue = userClaim.ClaimValue
                }.ToClaim();
                await RemoveClaimAsync(user, claim);
            }

            foreach (var role in newRoles)
            {
                var claim = new AppIdentityUserClaim
                {
                    UserId = user.Id,
                    ClaimType = ClaimTypes.Role,
                    ClaimValue = role.ToString()
                }.ToClaim();
                await AddClaimAsync(user, claim);
            }
        }
    }
}
