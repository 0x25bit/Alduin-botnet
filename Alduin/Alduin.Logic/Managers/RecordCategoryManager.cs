using AutoMapper;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;

namespace Alduin.Logic.Managers
{
    public class RecordCategoryManager : ManagerBase<RecordCategoryEntity, RecordCategoryDTO>, IRecordCategoryManager
    {
        public RecordCategoryManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        { }
    }
}
