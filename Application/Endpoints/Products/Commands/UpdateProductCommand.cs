using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Products.Commands
{
    public class UpdateProductCommand : IRequest<EndpointResult<ProductViewModel>>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }
    }
}
