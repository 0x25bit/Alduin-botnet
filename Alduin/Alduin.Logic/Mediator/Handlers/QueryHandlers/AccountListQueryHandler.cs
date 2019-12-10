using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class AccountListQueryHandler : IRequestHandler<GetAccountListQuery, AccountDTO[]>
    {
        private readonly IAccountRepository _accountRepository;

        public AccountListQueryHandler(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public Task<AccountDTO[]> Handle(GetAccountListQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var account = _accountRepository.GetAll();
            return Task.FromResult(account);
        }
    }
}
