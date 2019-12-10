using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.Managers
{
    public class RecordManager : ManagerBase<RecordEntity, RecordDTO>, IRecordManager
    {
        public RecordManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        { }
    }
}
