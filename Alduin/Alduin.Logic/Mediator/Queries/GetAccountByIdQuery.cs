using MediatR;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Queries
{
    public class GetAccountByIdQuery : IRequest<AccountDTO>
    {
        public int Id { get; set; }
    }
}
