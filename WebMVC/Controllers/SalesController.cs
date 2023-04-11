using Application.Endpoints.OrderTypes.Queries;
using Application.Endpoints.PaymentTypes.Queries;
using Application.Endpoints.Products.Queries;
using Application.Endpoints.SalesOrders.Commands;
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
        [HttpGet]
        public async Task<IActionResult> GetOrderTypes([FromQuery] GetOrderTypeQuery query)
            => Json(await _mediator.Send(query));

        [HttpGet]
        public async Task<IActionResult> GetPaymentTypes([FromQuery] GetPaymentTypeQuery query)
            => Json(await _mediator.Send(query));

        [HttpGet]
        public async Task<IActionResult> GetProducts([FromQuery] GetProductsQuery query)
            => Json(await _mediator.Send(query));

        [HttpPost]
        public async Task<IActionResult> AddSalesOrder([FromForm] AddSalesOrderCommand command)
            => Json(await _mediator.Send(command));
        #endregion
    }
}
