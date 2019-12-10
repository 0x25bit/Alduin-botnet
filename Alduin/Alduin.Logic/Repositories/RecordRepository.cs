using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class RecordRepository : RepositoryBase<RecordEntity, RecordDTO>, IRecordRepository
    {
        public RecordRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }
    }
}
