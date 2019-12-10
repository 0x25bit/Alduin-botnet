using MediatR;
using Alduin.Shared.Transaction;

namespace Alduin.Logic.Mediator.Commands
{
    public class DeleteUserCommand : IRequest<TransactionResult>
    {
        public int UserId { get; set; }
    }
}
