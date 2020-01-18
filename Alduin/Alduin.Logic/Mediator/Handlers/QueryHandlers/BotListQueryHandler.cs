using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class BotListQueryHandler : IRequestHandler<GetBotListQuery, BotDTO[]>
    {
        private readonly IBotRepository _BotRepository;
        public BotListQueryHandler(IBotRepository BotRepository)
        {
            _BotRepository = BotRepository;
        }
        public Task<BotDTO[]> Handle(GetBotListQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var Bot = _BotRepository.GetAll();

            return Task.FromResult(Bot);
        }
    }
}
