using Alduin.DataAccess.Entities.Base;
using Alduin.Common.Attributes;

namespace Alduin.DataAccess.Entities
{
    public class CreditCardEntity : EntityBase
    {
        [NotNull]
        public virtual string Name { get; set; }
    }
}
