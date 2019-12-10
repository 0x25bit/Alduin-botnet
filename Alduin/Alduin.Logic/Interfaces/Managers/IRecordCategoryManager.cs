using Alduin.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Alduin.DataAccess.Entities;
using Alduin.Shared.Interfaces.Managers;

namespace Alduin.Logic.Interfaces.Managers
{
    public interface IRecordCategoryManager : IManager<RecordCategoryEntity, RecordCategoryDTO>
    {}
}
