using Application.Endpoints.Auths.Queries;
using Application.Interfaces.Wrappers;
using Application.Models;
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
        public async Task<IActionResult> GetUsers()
            => Json(await _mediator.Send(new GetUserProfileQuery()));

        [HttpGet]
        public async Task<IActionResult> GetUserRoles(int id)
            => Json(await _mediator.Send(new GetUserRolesQuery() { Id = id }));
        #endregion
    }
}
