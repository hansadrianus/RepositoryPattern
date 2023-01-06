using Application.Models;
using Application.ViewModels;
using MediatR;

namespace Application.Endpoints.Auths
{
    public class LoginCommand : IRequest<EndpointResult<UserLoginViewModel>>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
