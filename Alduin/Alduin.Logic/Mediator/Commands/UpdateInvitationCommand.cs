using Alduin.Logic.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alduin.Logic.Mediator.Commands
{
    public class UpdateInvitationCommand : IRequest<ActionResult>
    {
        public int id { get; set; }
    }
}
