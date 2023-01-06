using Application.Models;
using Application.ViewModels;
using MediatR;

namespace Application.Endpoints.Auths
{
    public class RefreshTokenCommand : IRequest<EndpointResult<RefreshTokenViewModel>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
