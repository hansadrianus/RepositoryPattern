using API.Extensions;
using Application.Endpoints.SalesOrders.Commands;
using Application.Endpoints.SalesOrders.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace API.Controllers
{
    public class SalesOrderController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public SalesOrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetSalesOrderAsync([FromQuery] GetSalesOrderQuery query)
            => (await _mediator.Send(query)).ToActionResult();

        [HttpGet]
        public async Task<IActionResult> GetSalesOrderByDetailAsync([FromQuery] GetSalesOrderByDetailQuery query)
            => (await _mediator.Send(query)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> AddSalesOrderAsync([FromBody] AddSalesOrderCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSalesOrderAsync(int id, [FromBody] UpdateSalesOrderCommand command)
        {
            command.Id = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesOrderAsync(int id)
        {
            DeleteSalesOrderCommand command = new DeleteSalesOrderCommand() { Id = id };

            return (await _mediator.Send(command)).ToActionResult();
        }
    }
}
