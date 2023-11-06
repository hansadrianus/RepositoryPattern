using API.Extensions;
using Application.Endpoints.LanguageCultures.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ComponentController : ApplicationBaseController
    {
        private readonly IMediator _mediator;

        public ComponentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> GetLanguageCultures([FromQuery] GetLanguageCultureQuery query)
            => (await _mediator.Send(query)).ToActionResult();
    }
}
