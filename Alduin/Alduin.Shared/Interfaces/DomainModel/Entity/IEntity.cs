using System;

namespace Alduin.Shared.Interfaces.DomainModel.Entity
{
    public interface IEntity
    {
        int Id { get; }

        DateTime CreationDateUTC { get; }

        DateTime ModificationDateUTC { get; }
    }
}
