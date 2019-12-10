using Alduin.DataAccess.Entities;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.Managers;

namespace Alduin.Logic.Interfaces.Managers
{
    public interface IUserClaimManager : IManager<UserClaimEntity, UserClaimDTO>
    { }
}
