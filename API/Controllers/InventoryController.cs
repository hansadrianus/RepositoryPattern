using API.Extensions;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class InventoryController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public InventoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetProductStocksAsync([FromQuery] GetProductStockQuery query)
        //    => (await _mediator.Send(query)).ToActionResult();
    }
}
