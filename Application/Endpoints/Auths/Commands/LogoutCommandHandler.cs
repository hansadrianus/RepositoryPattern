using System.Security.Claims;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using AutoMapper;
using MediatR;

namespace Application.Endpoints.Auths.Commands
{
    public class LogoutCommandHandler : IRequestHandler<LogoutCommand, EndpointResult<string>>
    {
        private readonly IRepositoryWrapper _reposiroty;
        private readonly IMapper _mapper;

        public LogoutCommandHandler(IRepositoryWrapper reposiroty, IMapper mapper)
        {
            _reposiroty = reposiroty;
            _mapper = mapper;
        }

        public async Task<EndpointResult<string>> Handle(LogoutCommand request, CancellationToken cancellationToken)
        {
            string rawUserId = request.HttpContext.User.FindFirstValue("id");
            if (!Guid.TryParse(rawUserId, out Guid userId))
                return new EndpointResult<string>(EndpointResultStatus.Invalid, "Invalid token.");

            try
            {
                if (await _reposiroty.Auth.RemoveTokenAsync(userId, cancellationToken))
                    return new EndpointResult<string>(EndpointResultStatus.Success);

                return new EndpointResult<string>(EndpointResultStatus.Invalid, "Invalid token.");
            }
            catch (Exception ex)
            {
                return new EndpointResult<string>(EndpointResultStatus.Error, ex.Message);
            }
        }
    }
}
