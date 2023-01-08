using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Products.Queries
{
    public class GetProductsQuery : IRequest<EndpointResult<IEnumerable<ProductViewModel>>>
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string? Type { get; set; }
        public decimal? Price_GreaterThan { get; set; }
        public decimal? Price_LessThan { get; set; }
        public decimal? Price_GreaterThanEqual { get; set; }
        public decimal? Price_LessThanEqual { get; set; }
        public int? Stock_GreaterThan { get; set; }
        public int? Stock_LessThan { get; set; }
        public int? Stock_GreaterThanEqual { get; set; }
        public int? Stock_LessThanEqual { get; set; }
    }
}
