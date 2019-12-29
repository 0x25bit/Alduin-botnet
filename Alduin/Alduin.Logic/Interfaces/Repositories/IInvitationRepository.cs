using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;
using NHibernate.Mapping;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IInvitationRepository : IRepository<InvitationEntity, InvitationDTO>
    {
        InvitationDTO FindByInvitationKey(string InvitationKey);
        InvitationDTO[] FindByUserId(int userId);
    }
}
