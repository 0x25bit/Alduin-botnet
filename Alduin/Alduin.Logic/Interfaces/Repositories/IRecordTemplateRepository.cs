using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IRecordTemplateRepository : IRepository<RecordTemplateEntity, RecordTemplateDTO>
    {}
}
