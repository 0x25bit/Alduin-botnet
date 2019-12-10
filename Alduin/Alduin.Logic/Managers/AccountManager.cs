
using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.Managers
{
    public class AccountManager : ManagerBase<AccountEntity, AccountDTO>, IAccountManager
    {
        public AccountManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        { }
    }
}
