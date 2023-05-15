using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class UpdatePostSalesOrderCommand : IRequest<EndpointResult<SalesOrderViewModel>>
    {
        public int? Id { get; set; }
        public ICollection<OrderDetailCommand> OrderDetails { get; set; }
    }
}
