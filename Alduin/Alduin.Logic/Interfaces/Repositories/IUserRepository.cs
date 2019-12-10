using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Repositories;

namespace Alduin.Logic.Interfaces.Repositories
{
    public interface IUserRepository : IRepository<UserEntity, UserDTO>
    {
        UserDTO FindByUserName(string normalizedUserName);

        UserDTO[] GetByClaim(string claimType, string claimValue);
    }
}
