using AutoMapper;
using NHibernate;
using System.Collections.Generic;
using System.Linq;
using Alduin.DataAccess.Entities;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Repositories
{
    public class UserClaimRepository : RepositoryBase<UserClaimEntity, UserClaimDTO>, IUserClaimRepository
    {
        public UserClaimRepository(ISession session, IMapper mapper) : base(session, mapper)
        { }

        public UserClaimDTO[] GetByUserId(int userId)
        {
            var claims = _session.QueryOver<UserClaimEntity>()
                .Where(x => x.User.Id == userId)
                .List();

            var dtos = _mapper.Map<IList<UserClaimDTO>>(claims);
            return dtos.ToArray();
        }

        public UserClaimDTO[] GetSpecificClaimsByUserId(int userId, string claimType, string claimValue)
        {
            var query = _session.QueryOver<UserClaimEntity>()
                .Where(x => x.User.Id == userId);

            if (string.IsNullOrEmpty(claimType) == false)
                query = query.Where(x => x.ClaimType == claimType);

            if (string.IsNullOrEmpty(claimValue) == false)
                query = query.Where(x => x.ClaimValue == claimValue);

            var claims = query.List();

            var dtos = _mapper.Map<IList<UserClaimDTO>>(claims);
            return dtos.ToArray();
        }
    }
}
