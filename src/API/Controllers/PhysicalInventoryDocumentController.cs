using API.Extensions;
using Application.Endpoints.PhysicalInventoryDocuments.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PhysicalInventoryDocumentController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public PhysicalInventoryDocumentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> DraftPhysicalInventoryDocumentAsync([FromBody] DraftPhysicalInventoryDocumentCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPost]
        public async Task<IActionResult> PostPhysicalInventoryDocumentAsync([FromBody] PostPhysicalInventoryDocumentCommand command)
            => (await _mediator.Send(command)).ToActionResult();

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDraftPhysicalInventoryDocumentAsync(int id, [FromBody] UpdateDraftPhysicalInventoryDocumentCommand command)
        {
            command.Id = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePostPhysicalInventoryDocumentAsync(int id, [FromBody] UpdatePostPhysicalInventoryDocumentCommand command)
        {
            command.Id = id;

            return (await _mediator.Send(command)).ToActionResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhysicalInventoryDocument(int id)
            => (await _mediator.Send(new DeletePhysicalInventoryDocumentCommand() { Id = id })).ToActionResult();
    }
}
