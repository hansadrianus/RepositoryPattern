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
            GetUserProfileQuery command = new GetUserProfileQuery();
            if (Guid.TryParse(HttpContext.User.FindFirstValue("Uid"), out Guid uid))
                command.Uid = uid;
            else
                command.Uid = null;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpGet]
        public async Task<IActionResult> GetRolesAsync([FromQuery] GetRoleQuery query)
            => (await _mediator.Send(query)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync([FromBody] AddRoleCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoleAsync(Guid id, [FromBody] UpdateRoleCommand command)
        {
            command.Uid = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleAsync(Guid id)
            => (await _mediator.Send(new DeleteRoleCommand() { Uid = id })).ToActionResult();

        [HttpGet("{userId}/GetUserRoles")]
        public async Task<IActionResult> GetUserRolesAsync(Guid userId, [FromQuery] GetUserRolesQuery query)
        {
            query.UserId = userId;

            return (await _mediator.Send(query)).ToActionResult();
        }
    }
}
