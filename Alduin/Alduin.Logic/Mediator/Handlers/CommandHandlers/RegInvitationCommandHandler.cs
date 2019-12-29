using Alduin.DataAccess.Entities;
using Alduin.Logic.DTOs;
using Alduin.Logic.Identity;
using Alduin.Logic.Interfaces.Managers;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Commands;
using Alduin.Shared.DTOs;
using Alduin.Shared.Interfaces.UnitOfWork;
using AutoMapper;
using MediatR;
using NHibernate;
using System.Threading;
using System.Threading.Tasks;

namespace Alduin.Logic.Mediator.Handlers.CommandHandlers
{
    public class RegInvitationCommandHandler : IRequestHandler<RegInvitationCommand, ActionResult>
    {
        private readonly IInvitationRepository _invitationRepository;
        private readonly IInvitationManager _invitationManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        internal static ISession _session;
        public RegInvitationCommandHandler(IMapper mapper,IUnitOfWork unitOfWork, IInvitationRepository accountRepository, IInvitationManager invitationManager, ISession session)
        {
            _unitOfWork = unitOfWork;
            _invitationRepository = accountRepository;
            _mapper = mapper;
            _invitationManager = invitationManager;
            _session = session;
        }
        public async Task<ActionResult> Handle(RegInvitationCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            //_unitOfWork.BeginTransaction();
            var user = _session.Load<UserEntity>(request.UserId);
            using (var trans = _session.BeginTransaction())
            {
                var Invitation = new InvitationEntity
                {
                    invitationKey = request.invitationKey,
                    Used = false,
                    User = user
                };
                _session.Save(Invitation);
                trans.Commit();
            }
            
            return new ActionResult { Suceeded = true };
        }
    }
}
