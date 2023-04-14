using Application.Endpoints.OrderTypes.Queries;
using Application.Endpoints.PaymentTypes.Queries;
using Application.Endpoints.Products.Queries;
using Application.Endpoints.SalesOrders.Commands;
using Application.Endpoints.SalesOrders.Queries;
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
            ViewData["Title"] = "Create Sales Order";
            return View();
        }

        public IActionResult ChangeSalesOrder()
        {
            ViewData["Title"] = "Change Sales Order";
            return View();
        }

        public IActionResult DisplaySalesOrder()
        {
            ViewData["Title"] = "Display Sales Order";
            return View();
        }

        public async Task<IActionResult> SearchOrderToChange(string orderNumber)
        {
            GetSalesOrderQuery query = new GetSalesOrderQuery()
            {
                OrderNumber = orderNumber
            };
            ViewData["Title"] = "Change Sales Order";

            return View("SalesOrderToChange", await _mediator.Send(query));
        }

        public async Task<IActionResult> SearchOrderToDisplay(string orderNumber)
        {
            ViewData["Title"] = "Display Sales Order";
            return View("SalesOrderToDisplay", orderNumber);
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

        [HttpGet]
        public async Task<IActionResult> GetSalesOrderByDocumentNumber([FromQuery] GetSalesOrderQuery query)
            => Json(await _mediator.Send(query));
        #endregion
    }
}
