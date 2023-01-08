using API.Extensions;
using Application.Endpoints.Products.Commands;
using Application.Endpoints.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAsync([FromQuery]GetProductsQuery query) 
            => (await _mediator.Send(query)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> AddProductAsync([FromBody]AddProductCommand command)
            => (await _mediator.Send(command)).ToActionResult();
    }
}
