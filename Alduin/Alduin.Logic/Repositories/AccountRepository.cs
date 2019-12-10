using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class AccountRepository : RepositoryBase<AccountEntity, AccountDTO>, IAccountRepository
    {
        public AccountRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }
    }
}
