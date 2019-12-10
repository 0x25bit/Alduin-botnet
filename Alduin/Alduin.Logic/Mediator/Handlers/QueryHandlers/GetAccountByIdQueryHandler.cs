using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class GetAccountByIdQueryHandler : IRequestHandler<GetAccountByIdQuery, AccountDTO>
    {
        private readonly IAccountRepository _accountRepository;

        public GetAccountByIdQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<AccountDTO> Handle(GetAccountByIdQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var account = _accountRepository.Get(request.Id);

            return Task.FromResult(account);
        }
    }
}
