using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class GetInvitationByKeyQueryHandler : IRequestHandler<GetInvitationByKeyQuery, InvitationDTO>
    {
        private readonly IInvitationRepository _invitationRepository;
        public GetInvitationByKeyQueryHandler(IInvitationRepository invitationRepository)
        {
            _invitationRepository = invitationRepository;
        }

        public Task<InvitationDTO> Handle(GetInvitationByKeyQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var invitation = _invitationRepository.FindByInvitationKey(request.invitationKey);

            return Task.FromResult(invitation);
        }
    }
}
