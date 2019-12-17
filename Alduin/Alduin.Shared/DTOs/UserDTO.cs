using System;
using Alduin.Shared.DTOs.Base;

namespace Alduin.Shared.DTOs
{
    public class UserDTO : DTOBase
    {
        public string Name { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public DateTime? LastAttemptUTC { get; set; }

        public int AccessFailedCount { get; set; }

        public DateTime? LastLoggedInUTC { get; set; }

        public bool IsLastLoginPersistent { get; set; }

        public string SecurityStamp { get; set; }

        public bool LockoutEnabled { get; set; }

        public DateTime? LockoutEnd { get; set; }
    }
}
