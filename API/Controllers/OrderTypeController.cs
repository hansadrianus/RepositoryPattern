using API.Extensions;
using Application.Endpoints.OrderTypes.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class OrderTypeController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public OrderTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderTypeAsync([FromQuery] GetOrderTypeQuery query)
            => (await _mediator.Send(query)).ToActionResult();
    }
}
