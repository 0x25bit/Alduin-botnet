using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;
using AutoMapper;
using NHibernate;

namespace Alduin.Logic.Managers
{
    public class BotManager : ManagerBase<BotEntity, BotDTO>, IBotManager
    {
        public BotManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        {
        }
    }
}
