using Application.Models;
using Application.ViewModels;
using MediatR;

namespace Application.Endpoints.Auths.Commands
{
    public class LoginCommand : IRequest<EndpointResult<UserLoginViewModel>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Lcid { get; set; }
    }
}
