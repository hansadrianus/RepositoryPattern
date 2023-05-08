using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Inventories.Commands
{
    public class UpdateProductStockCommand : IRequest<EndpointResult<ProductStockViewModel>>
    {
        public int Id { get; set; }
        public int Stock { get; set; }
    }
}
