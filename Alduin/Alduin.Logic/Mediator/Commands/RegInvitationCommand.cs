using Alduin.Logic.DTOs;
using Alduin.Shared.DTOs;
using MediatR;

namespace Alduin.Logic.Mediator.Commands
{
    public class RegInvitationCommand : IRequest<ActionResult>
    {
        public string invitationKey { get; set; }
        //public UserDTO User { get; set; }
        public bool Used { get; set; }
        public int UserId { get; set; }
    }
}
