using Application.Models;
using Application.ViewModels;
using MediatR;

namespace Application.Endpoints.Auths.Commands
{
    public class RefreshTokenCommand : IRequest<EndpointResult<RefreshTokenViewModel>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Lcid { get; set; }
    }
}
