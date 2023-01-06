using System.Net;
using Application.Models;
using Application.Models.Enumerations;
using Microsoft.AspNetCore.Mvc;

namespace API.Extensions
{
    public static class EndpointResultExtensions
    {
        public static ActionResult ToActionResult(this EndpointResult endpointResult)
        {
            return endpointResult.Status switch
            {
                EndpointResultStatus.Success => new OkResult(),
                EndpointResultStatus.BadRequest => new BadRequestResult(),
                EndpointResultStatus.NotFound => new NotFoundResult(),
                EndpointResultStatus.Invalid when endpointResult.Messages.Count() > 0 =>
                    new UnprocessableEntityObjectResult(endpointResult),
                EndpointResultStatus.Invalid => new UnprocessableEntityResult(),
                EndpointResultStatus.Duplicate => new ConflictResult(),
                EndpointResultStatus.Unauthorized => new UnauthorizedResult(),
                EndpointResultStatus.Gone => new StatusCodeResult((int)HttpStatusCode.Gone),
                _ => new StatusCodeResult((int)HttpStatusCode.InternalServerError)
            };
        }

        public static ActionResult ToActionResult<TResult>(this EndpointResult<TResult> endpointResult)
        {
            return endpointResult.Status switch
            {
                EndpointResultStatus.Success => new OkObjectResult(endpointResult),
                EndpointResultStatus.BadRequest => new BadRequestObjectResult(endpointResult),
                EndpointResultStatus.Duplicate => new ConflictObjectResult(endpointResult),
                _ => ((EndpointResult)endpointResult).ToActionResult()
            };
        }
    }
}
