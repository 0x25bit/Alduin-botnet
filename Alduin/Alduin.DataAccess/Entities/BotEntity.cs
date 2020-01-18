using Alduin.DataAccess.Entities.Base;
using System;
using System.Net;

namespace Alduin.DataAccess.Entities
{
    public class BotEntity : EntityBase
    {
        public virtual string UserName { get; set; }
        public virtual string KeyUnique { get; set; }
        public virtual string KeyCertified { get; set; }
        public virtual string CountryCode { get; set; }
        public virtual string Domain { get; set; }
        public virtual string LastIPAddress { get; set; }
        public virtual DateTime? LastLoggedInUTC { get; set; }
    }
}
