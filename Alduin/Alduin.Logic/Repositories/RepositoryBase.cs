using AutoMapper;
using NHibernate;
using System.Collections.Generic;
using System.Linq;
using Alduin.DataAccess.Entities.Base;
using Alduin.Shared.DTOs.Base;
using Alduin.Shared.Interfaces.DomainModel.DTO;
using Alduin.Shared.Interfaces.DomainModel.Entity;
using Alduin.Shared.Interfaces.Repositories;

namespace Alduin.Logic.Repositories
{
    public abstract class RepositoryBase<TEntity, TDTO> : IRepository<TEntity, TDTO>
        where TEntity : EntityBase, IEntity, new()
        where TDTO : DTOBase, IDTO, new()
    {
        protected readonly ISession _session;
        protected readonly IMapper _mapper;

        public RepositoryBase(ISession session, IMapper mapper)
        {
            _session = session;
            _mapper = mapper;
        }

        public TDTO Get(int id)
        {
            var entity = _session.Get<TEntity>(id);
            var dto = _mapper.Map<TDTO>(entity);
            return dto;
        }

        public TDTO[] Get(IEnumerable<int> ids)
        {
            var entities = new List<TEntity>();

            foreach (var id in ids)
            {
                var entity = _session.Get<TEntity>(id);
                if (entity != null)
                    entities.Add(entity);
            }

            var dtos = _mapper.Map<IList<TDTO>>(entities);
            return dtos.ToArray();
        }

        public TDTO[] GetAll()
        {
            var entities = _session.QueryOver<TEntity>().List();
            var dtos = _mapper.Map<IList<TDTO>>(entities);

            return dtos.ToArray();
        }
    }
}
