using Alduin.DataAccess.Entities;
using Alduin.Logic.DTOs;
using Alduin.Logic.Mediator.Commands;
using MediatR;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alduin.Logic.Mediator.Handlers.CommandHandlers
{
    public class SetUsedInvitationCommandHandler : IRequestHandler<UpdateInvitationCommand, ActionResult>
    {
        internal static ISession _session;

        public SetUsedInvitationCommandHandler(ISession session)
        {
            _session = session;
        }

        public async Task<ActionResult> Handle(UpdateInvitationCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            InvitationEntity previous = _session.Get<InvitationEntity>(request.id);
            previous.Used = true;
            previous.ModificationDateUTC = DateTime.UtcNow;
            using (var trans = _session.BeginTransaction())
            {
                _session.Update(previous);
                trans.Commit();
            }

            return new ActionResult { Suceeded = true };
        }
    }
}
