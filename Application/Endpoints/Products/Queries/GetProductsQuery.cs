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
        public decimal? PriceGreaterThan { get; set; }
        public decimal? PriceLessThan { get; set; }
        public decimal? PriceGreaterThanEqual { get; set; }
        public decimal? PriceLessThanEqual { get; set; }
        public int? StockGreaterThan { get; set; }
        public int? StockLessThan { get; set; }
        public int? StockGreaterThanEqual { get; set; }
        public int? StockLessThanEqual { get; set; }
    }
}
