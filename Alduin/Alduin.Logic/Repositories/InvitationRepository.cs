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
    public class InvitationRepository : RepositoryBase<InvitationEntity, InvitationDTO>, IInvitationRepository
    {
        public InvitationRepository(ISession session, IMapper mapper) : base(session, mapper)
        {
        }
        public InvitationDTO FindByInvitationKey(string InvitationKey)
        {
            var query = _session.QueryOver<InvitationEntity>()
                .Where(x => x.invitationKey == InvitationKey)
                .List()
                .FirstOrDefault();

            if (query == null)
                return null;

            var dto = _mapper.Map<InvitationDTO>(query);
            return dto;
        }
        public InvitationDTO[] FindByUserId(int userId)
        {
            var query = _session.QueryOver<InvitationEntity>()
                .Where(x => x.User.Id == userId)
                .List();

            if (query == null)
                return null;

            var dto = _mapper.Map<InvitationDTO[]>(query);
            return dto;
        }
    }
}
