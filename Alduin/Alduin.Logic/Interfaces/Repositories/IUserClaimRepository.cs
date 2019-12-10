using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IUserClaimRepository : IRepository<UserClaimEntity, UserClaimDTO>
    {
        UserClaimDTO[] GetByUserId(int userId);

        UserClaimDTO[] GetSpecificClaimsByUserId(int userId, string claimType = null, string claimValue = null);
    }
}
