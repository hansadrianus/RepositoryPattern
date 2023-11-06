using Application.Endpoints.Inventories.Commands;
using Application.Endpoints.Products.Commands;
using Application.Endpoints.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace WebMVC.Controllers
{
    public class InventoriesController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public InventoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region View Controllers
        public IActionResult StockOpname()
        {
            ViewData["Title"] = "Physical Inventory Adjustment";
            return View();
        }
        #endregion

        #region JSON API Controllers
        [HttpGet]
        public async Task<IActionResult> GetInventoryStocks(GetProductsQuery query)
            => Json(await _mediator.Send(query));

        [HttpPut]
        public async Task<IActionResult> UpdateInventoryStock(int id, UpdateProductStockCommand command)
        {
            command.Id = id;

            return Json(await _mediator.Send(command));
        }
        #endregion
    }
}
