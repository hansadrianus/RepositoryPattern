using API.Extensions;
using Application.Endpoints.Menus.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AppMenuController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public AppMenuController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMenusAsync([FromQuery] GetMenuQuery query)
            => (await _mediator.Send(query)).ToActionResult();
    }
}
