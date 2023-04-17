﻿using Application.Endpoints.Auths.Commands;
using Application.Endpoints.Auths.Queries;
using Application.Endpoints.Menus.Commands;
using Application.Endpoints.Menus.Queries;
using Application.Interfaces.Services;
using Application.Interfaces.Wrappers;
using Application.Models;
using Application.Models.Enumerations;
using Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    [Authorize(Roles = "Administrator")]
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

        public IActionResult Roles()
            => View();

        public async Task<IActionResult> MenuRolesAsync(int id)
            => View((await _mediator.Send(new GetRoleQuery() { Id = id })).Data.FirstOrDefault());
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

        [HttpGet]
        public async Task<IActionResult> GetRoles([FromQuery] GetRoleQuery query)
           => Json(await _mediator.Send(query));

        [HttpPost]
        public async Task<IActionResult> AddRole([FromForm] AddRoleCommand command)
            => Json(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> UpdateRole(int id, [FromForm] UpdateRoleCommand command)
        {
            command.Id = id;

            return Json(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetMenus(int roleId, [FromQuery] GetMenuRolesQuery query)
        {
            query.RoleId = roleId;

            return Json(await _mediator.Send(query));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMenuRoles(int roleId, [FromForm] MenuRolesCommand command)
        {
            command.RoleId = roleId;
            var result = await _mediator.Send(command);
            var menus = await _mediator.Send(new GetMenuQuery() { Id = result.Data.AppMenuId });
            result.Data.MenuName = menus.Data.FirstOrDefault().MenuName;

            return Json(result);
        }
        #endregion
    }
}
