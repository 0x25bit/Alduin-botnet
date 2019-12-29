using Alduin.Shared.DTOs;
using MediatR;


namespace Alduin.Logic.Mediator.Queries
{
    public class GetInvitationByKeyQuery : IRequest<InvitationDTO>
    {
        public string invitationKey { get; set; }
    }
}
