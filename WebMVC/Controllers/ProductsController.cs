using Application.Endpoints.Products.Commands;
using Application.Endpoints.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class ProductsController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        #region View Controllers
        public IActionResult CreateProduct()
        {
            ViewData["Title"] = "Create Product";
            return View();
        }

        public IActionResult ChangeProduct()
        {
            ViewData["Title"] = "Change Product";
            return View();
        }

        public IActionResult DisplayProduct()
        {
            ViewData["Title"] = "Display Product";
            return View();
        }

        public IActionResult SearchProductToChange(string productCode)
        {
            ViewData["Title"] = "Change Product";
            return View("ProductToChange", productCode);
        }

        public IActionResult SearchProductToDisplay(string productCode)
        {
            ViewData["Title"] = "Display Product";
            return View("ProductToDisplay", productCode);
        }
        #endregion

        #region JSON API Controllers
        [HttpPost]
        public async Task<IActionResult> AddProduct([FromForm] AddProductCommand command)
            => Json(await _mediator.Send(command));

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, [FromForm] UpdateProductCommand command)
        {
            command.Id = id;

            return Json(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetProductByProductCode([FromQuery] GetProductsQuery query)
            => Json(await _mediator.Send(query));
        #endregion
    }
}
