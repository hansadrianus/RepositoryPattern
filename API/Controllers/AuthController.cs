using API.Extensions;
using Application.Endpoints.Auths.Commands;
using Application.Endpoints.Auths.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    public class AuthController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> RegisterUserAsync([FromBody] RegisterCommand command) =>
            (await _mediator.Send(command)).ToActionResult();

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand command) =>
            (await _mediator.Send(command)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenCommand command) =>
            (await _mediator.Send(command)).ToActionResult();

        [HttpDelete]
        public async Task<IActionResult> LogoutAsync()
        {
            LogoutCommand command = new LogoutCommand();
            command.HttpContext = HttpContext;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpGet]
        public async Task<IActionResult> UserProfileAsync()
        {
            GetUserProfile command = new GetUserProfile();
            command.Id = HttpContext.User.FindFirstValue("id");

            return (await _mediator.Send(command)).ToActionResult();
        }
    }
}
