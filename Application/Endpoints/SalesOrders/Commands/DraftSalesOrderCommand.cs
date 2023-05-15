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
    public class DraftSalesOrderCommand : IRequest<EndpointResult<SalesOrderViewModel>>
    {
        public int OrderTypeId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int PaymentTypeId { get; set; }
        public ICollection<OrderDetailCommand> OrderDetails { get; set; }
    }
}
