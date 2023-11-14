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
        public async Task<IActionResult> DraftSalesOrderAsync([FromBody] DraftSalesOrderCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> PostSalesOrderAsync([FromBody] PostSalesOrderCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePostSalesOrderAsync(Guid id, [FromBody] UpdatePostSalesOrderCommand command)
        {
            command.Uid = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDraftSalesOrderAsync(Guid id, [FromBody] UpdateDraftSalesOrderCommand command)
        {
            command.Uid = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesOrderAsync(int id)
            => (await _mediator.Send(new DeleteSalesOrderCommand() { Id = id })).ToActionResult();
    }
}
