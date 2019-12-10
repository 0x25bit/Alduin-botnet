using System;
using Alduin.DataAccess.Entities.Base;

namespace Alduin.DataAccess.Entities
{
    public class UserEntity : LogicalEntityBase
    {
        public virtual string Name { get; set; }

        public virtual string UserName { get; set; }

        public virtual string NormalizedUserName { get; set; }

        public virtual string PasswordHash { get; set; }

        public virtual string Email { get; set; }

        public virtual DateTime? LastAttemptUTC { get; set; }

        public virtual int AccessFailedCount { get; set; }

        public virtual DateTime? LastLoggedInUTC { get; set; }

        public virtual bool IsLastLoginPersistent { get; set; }

        public virtual string SecurityStamp { get; set; }

        public virtual bool LockoutEnabled { get; set; }

        public virtual DateTime? LockoutEnd { get; set; }
    }
}
