using System;
using Alduin.Shared.Interfaces.DomainModel.Entity;

namespace Alduin.DataAccess.Entities.Base
{
    public abstract class EntityBase : IEntity
    {
        public virtual int Id { get; set; }

        public virtual DateTime CreationDateUTC { get; set; }

        public virtual DateTime ModificationDateUTC { get; set; }

        protected EntityBase()
        {
            CreationDateUTC = DateTime.UtcNow;
            ModificationDateUTC = DateTime.UtcNow;
        }
    }
}
