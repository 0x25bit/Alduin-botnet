using System.Collections.Generic;
using Alduin.Shared.Interfaces.DomainModel.DTO;
using Alduin.Shared.Interfaces.DomainModel.Entity;
using Alduin.Shared.Transaction;

namespace Alduin.Shared.Interfaces.Managers
{
    public interface IManager<TEntity, TDTO>
        where TEntity : IEntity
        where TDTO : IDTO
    {
        TransactionResult Save(TDTO dto);

        TransactionResult Delete(int id);

        TransactionResult Delete(IEnumerable<int> ids);
    }
}
