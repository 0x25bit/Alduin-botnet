using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Alduin.Shared.Enums;

namespace Alduin.Logic.Identity
{
    public class AppIdentityUserClaim : IdentityUserClaim<int>
    {
        public AppIdentityUserClaim()
        { }

        public AppIdentityUserClaim(AppIdentityUser identityUser, Role role)
        {
            UserId = identityUser.Id;
            ClaimType = ClaimTypes.Role;
            ClaimValue = role.ToString();
        }
    }
}
