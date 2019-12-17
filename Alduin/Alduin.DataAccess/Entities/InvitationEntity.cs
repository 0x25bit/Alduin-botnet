using Alduin.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.DataAccess.Entities
{
    public class InvitationEntity : EntityBase
    {
        public virtual string invitationKey { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual bool Used { get; set; }
    }
}
