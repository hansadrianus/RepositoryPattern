using API.Extensions;
using Application.Endpoints.PaymentTypes.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PaymentTypeController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public PaymentTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetPaymentTypeAsync([FromQuery] GetPaymentTypeQuery query)
            => (await _mediator.Send(query)).ToActionResult();
    }
}
