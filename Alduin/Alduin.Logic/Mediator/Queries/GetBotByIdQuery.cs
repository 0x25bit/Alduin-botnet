using Alduin.Shared.DTOs;
using MediatR;
namespace Alduin.Logic.Mediator.Queries
{
    public class GetBotByIdQuery : IRequest<BotDTO>
    {
        public int Id { get; set; }
    }
}
