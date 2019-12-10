using MediatR;
using System.Collections.Generic;

namespace Alduin.Logic.Mediator.Queries
{
    public class IdentityOptionsQuery : IRequest<IList<string>>
    { }
}
