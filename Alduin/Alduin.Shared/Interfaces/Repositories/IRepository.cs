using System.Collections.Generic;
using Alduin.Shared.Interfaces.DomainModel.DTO;
using Alduin.Shared.Interfaces.DomainModel.Entity;

namespace Alduin.Shared.Interfaces.Repositories
{
    public interface IRepository<TEntity, TDTO>
        where TEntity : IEntity
        where TDTO : IDTO
    {
        TDTO Get(int id);

        TDTO[] Get(IEnumerable<int> ids);

        TDTO[] GetAll();
    }
}
