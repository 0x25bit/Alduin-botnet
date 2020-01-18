using Alduin.Shared.DTOs;
using MediatR;

namespace Alduin.Logic.Mediator.Queries
{
    public class GetBotListQuery : IRequest<BotDTO[]>
    {
    }
}
