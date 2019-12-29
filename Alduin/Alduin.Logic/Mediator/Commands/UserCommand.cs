using Alduin.Logic.DTOs;
using MediatR;
using System;

namespace Alduin.Logic.Mediator.Commands
{
    public class UserCommand : IRequest<ActionResult>
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public DateTime? LastAttemptUTC { get; set; }

        public virtual int AccessFailedCount { get; set; }

        public DateTime? LastLoggedInUTC { get; set; }

        public bool IsLastLoginPersistent { get; set; }

        public string SecurityStamp { get; set; }

        public bool LockoutEnabled { get; set; }

        public DateTime? LockoutEnd { get; set; }
    }
}
