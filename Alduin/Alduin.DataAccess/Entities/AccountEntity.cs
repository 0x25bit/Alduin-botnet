using Alduin.DataAccess.Entities.Base;
using Alduin.Shared.Enums;

namespace Alduin.DataAccess.Entities
{
    public class AccountEntity : EntityBase
    {
        public virtual string Name { get; set; }
        public virtual double Balance { get; set; }
        public virtual AccountType AccountType { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
