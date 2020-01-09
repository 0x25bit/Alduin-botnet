using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;
using Alduin.Shared.Transaction;
using AutoMapper;
using NHibernate;

namespace Alduin.Logic.Managers
{
    public class InvitationManager : ManagerBase<InvitationEntity, InvitationDTO>, IInvitationManager
    {
        public InvitationManager(ISession session, IMapper mapper, IUnitOfWork unitOfWork) : base(session, mapper, unitOfWork)
        {}
    }
}
