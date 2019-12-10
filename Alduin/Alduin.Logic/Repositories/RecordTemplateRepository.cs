using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class RecordTemplateRepository : RepositoryBase<RecordTemplateEntity, RecordTemplateDTO>, IRecordTemplateRepository
    {
        public RecordTemplateRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }
    }
}
