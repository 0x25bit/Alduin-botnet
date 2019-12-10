using System;
using System.Collections.Generic;
using System.Text;
using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IAccountRepository : IRepository<AccountEntity, AccountDTO>
    {}
}
