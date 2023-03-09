using Application.Endpoints.Auths.Commands;
using Application.Endpoints.Auths.Queries;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class AuthController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region View Controllers
        public IActionResult Users()
            => View();

        public async Task<IActionResult> UserRoles(int id)
            => View((await _mediator.Send(new GetUserProfileQuery() { Id = id })).Data.FirstOrDefault());
        #endregion

        #region JSON API Controller
        [HttpGet]
        public async Task<IActionResult> GetUsers([FromQuery] GetUserProfileQuery query)
            => Json(await _mediator.Send(query));

        [HttpPost]
        public async Task<IActionResult> AddUser([FromForm] AddUserCommand command)
            => Json(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> UpdateUser(int id, [FromForm] UpdateUserCommand command)
        {
            command.Id = id;

            return Json(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetUserRoles(int id, [FromQuery] GetUserRolesQuery query)
        {
            query.UserId = id;

            return Json(await _mediator.Send(query));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserRoles(int id, [FromForm] UserRolesCommand command)
        {
            command.UserId = id;
            var result = await _mediator.Send(command);
            var roles = await _mediator.Send(new GetRoleQuery() { Id = result.Data.RoleId });
            result.Data.RoleName = roles.Data.FirstOrDefault().Name;

            return Json(result);
        }
        #endregion
    }
}
