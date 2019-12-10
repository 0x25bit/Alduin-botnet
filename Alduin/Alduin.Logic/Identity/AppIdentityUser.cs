using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Alduin.Logic.Identity
{
    public class AppIdentityUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public DateTime? LastAttemptUTC { get; set; }

        public int Attempts { get; set; }

        public DateTime? LastLoggedInUTC { get; set; }

        public bool IsLastLoginPersistent { get; set; }

        public IList<AppIdentityUserClaim> UserClaims { get; set; }
    }
}
