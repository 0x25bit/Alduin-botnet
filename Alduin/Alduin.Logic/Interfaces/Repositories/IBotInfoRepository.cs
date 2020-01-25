using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IBotInfoRepository : IRepository<BotInfoEntity, BotInfoDTO>
    {
    }
}
