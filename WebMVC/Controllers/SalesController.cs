using Application.Endpoints.OrderTypes.Queries;
using Application.Interfaces.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class SalesController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public SalesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region View Controllers
        public IActionResult CreateSalesOrder()
        {
            return View();
        }

        public IActionResult ChangeSalesOrder()
        {
            return View();
        }

        public IActionResult DisplaySalesOrder()
        {
            return View();
        }
        #endregion

        #region JSON API Controller
        public async Task<IActionResult> GetOrderTypes([FromQuery] GetOrderTypeQuery query)
            => Json(await _mediator.Send(query));
        #endregion
    }
}
