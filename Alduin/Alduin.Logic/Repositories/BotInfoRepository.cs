using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;
using AutoMapper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.Logic.Repositories
{
    public class BotInfoRepository : RepositoryBase<BotInfoEntity, BotInfoDTO>, IBotInfoRepository
    {
        public BotInfoRepository(ISession session, IMapper mapper) : base(session, mapper)
        {
        }
    }
}
