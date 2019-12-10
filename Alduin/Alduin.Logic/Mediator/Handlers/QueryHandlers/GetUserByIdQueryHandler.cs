using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Alduin.Logic.Interfaces.Repositories;
using Alduin.Logic.Mediator.Queries;
using Alduin.Shared.DTOs;

namespace Alduin.Logic.Mediator.Handlers.QueryHandlers
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserDTO>
    {
        private readonly IUserRepository _userRepository;

        public GetUserByIdQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var user = _userRepository.Get(request.UserId);
            return Task.FromResult(user);
        }
    }
}
