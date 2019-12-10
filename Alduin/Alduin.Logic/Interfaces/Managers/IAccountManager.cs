using Alduin.DataAccess.Entities;
using Alduin.Shared.Interfaces.Managers;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Interfaces.Managers
{
    public interface IAccountManager : IManager<AccountEntity, AccountDTO>
    {}
}
