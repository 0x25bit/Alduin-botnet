using MediatR;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Queries
{
    public class GetAccountListQuery : IRequest<AccountDTO[]>
    {
    }
}
