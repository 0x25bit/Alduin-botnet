using MediatR;
using Alduin.Logic.DTOs;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Commands
{
    public class RegisterCommand : IRequest<ActionResult>
    {
        public UserDTO User { get; set; }

        public string Password { get; set; }
    }
}
