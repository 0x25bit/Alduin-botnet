using MediatR;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Queries
{
    public class GetUserByIdQuery : IRequest<UserDTO>
    {
        public int UserId { get; set; }
    }
}
