using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Filters
{
    public class AuthorizationHeaderParameterOperationFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var filterPipeline = context.ApiDescription.ActionDescriptor.FilterDescriptors;
            var isAuthorized = filterPipeline.Select(q  => q.Filter).Any(q => q is AuthorizeFilter);
            var allowAnonymous = filterPipeline.Select(q => q.Filter).Any(q => q is IAllowAnonymousFilter);

            if (isAuthorized && !allowAnonymous)
            {
                if (operation.Parameters == null)
                    operation.Parameters = new List<OpenApiParameter>();

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "x-request-time",
                    In = ParameterLocation.Header,
                    Description = "Unix Timestamp",
                    Required = true,
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                    }
                });

                operation.Parameters.Add(new OpenApiParameter
                {
                    Name = "api-token",
                    In = ParameterLocation.Header,
                    Description = "API Token",
                    Required = true,
                    Schema = new OpenApiSchema
                    {
                        Type = "string",
                    }
                });
            }
        }
    }
}
