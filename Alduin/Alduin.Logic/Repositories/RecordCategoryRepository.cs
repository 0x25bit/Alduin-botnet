using AutoMapper;
using NHibernate;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class RecordCategoryRepository : RepositoryBase<RecordCategoryEntity, RecordCategoryDTO>, IRecordCategoryRepository
    {
        public RecordCategoryRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }
    }
}
