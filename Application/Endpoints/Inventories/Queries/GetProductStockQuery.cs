using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Inventories.Queries
{
    public class GetProductStockQuery : IRequest<EndpointResult<IEnumerable<ProductStockViewModel>>>
    {
        public int? Id { get; set; }
        public string? ProductCode { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
    }
}
