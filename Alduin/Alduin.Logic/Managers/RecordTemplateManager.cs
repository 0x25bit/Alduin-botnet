using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.Managers
{
    public class RecordTemplateManager : ManagerBase<RecordTemplateEntity, RecordTemplateDTO>, IRecordTemplateManager
    {
        public RecordTemplateManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        { }
    }
}
