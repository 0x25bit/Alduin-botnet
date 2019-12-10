using AutoMapper;
using NHibernate;
using NHibernate.SqlCommand;
using System.Collections.Generic;
using System.Linq;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class UserRepository : RepositoryBase<UserEntity, UserDTO>, IUserRepository
    {
        public UserRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }

        public UserDTO FindByUserName(string normalizedUserName)
        {
            var user = _session.QueryOver<UserEntity>()
                .Where(x => x.NormalizedUserName == normalizedUserName)
                .List()
                .FirstOrDefault();

            if (user == null)
                return null;

            var dto = _mapper.Map<UserDTO>(user);
            return dto;
        }

        public UserDTO[] GetByClaim(string claimType, string claimValue)
        {
            UserEntity parentAlias = null;
            UserClaimEntity claimAlias = null;

            var users = _session.QueryOver(() => parentAlias)
                .JoinEntityAlias(
                    () => claimAlias,
                    () => claimAlias.User.Id == parentAlias.Id,
                    JoinType.LeftOuterJoin)
                .Where(x => claimAlias.ClaimType == claimType && claimAlias.ClaimValue == claimValue)
                .List();

            var dtos = _mapper.Map<IList<UserDTO>>(users);
            return dtos.ToArray()
                ;
        }
    }
}
