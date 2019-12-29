using Alduin.Shared.DTOs;
using MediatR;

namespace Alduin.Logic.Mediator.Queries
{
    public class GetInvitationByUserQuery : IRequest<InvitationDTO[]>
    {
        public int UserId { get; set; }
    }
}
