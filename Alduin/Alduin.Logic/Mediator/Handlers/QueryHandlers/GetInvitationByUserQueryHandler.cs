using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class GetInvitationByUserQueryHandler : IRequestHandler<GetInvitationByUserQuery, InvitationDTO[]>
    {
        private readonly IInvitationRepository _invitationRepository;
        public GetInvitationByUserQueryHandler(IInvitationRepository invitationRepository)
        {
            _invitationRepository = invitationRepository;
        }
        public Task<InvitationDTO[]> Handle(GetInvitationByUserQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var invitation = _invitationRepository.FindByUserId(request.UserId);

            return Task.FromResult(invitation);
        }
    }
}
