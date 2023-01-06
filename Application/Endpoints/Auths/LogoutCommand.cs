using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Endpoints.Auths
{
    public class LogoutCommand : IRequest<EndpointResult<string>>
    {
        public HttpContext? HttpContext { get; set; }
    }
}
