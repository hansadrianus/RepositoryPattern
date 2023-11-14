using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Filters
{
    public class JsonIgnoreFilter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (context.ApiDescription == null || operation.Parameters == null)
                return;

            if (!context.ApiDescription.ParameterDescriptions.Any())
                return;

            context.ApiDescription.ParameterDescriptions.Where(p => p.Source.Equals(BindingSource.Form)
                        && p.CustomAttributes().Any(p => p.GetType().Equals(typeof(JsonIgnoreAttribute)))).ToList()
                        .ForEach(p => operation.RequestBody.Content.Values.Single(v => v.Schema.Properties.Remove(p.Name)));

            context.ApiDescription.ParameterDescriptions.Where(p => p.Source.Equals(BindingSource.Query)
                        && p.CustomAttributes().Any(p => p.GetType().Equals(typeof(JsonIgnoreAttribute)))).ToList()
                        .ForEach(p => operation.Parameters.Remove(operation.Parameters.Single(w => w.Name.Equals(p.Name))));
        }
    }
}
