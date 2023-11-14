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
    public class UpdateDraftSalesOrderCommand : IRequest<EndpointResult<SalesOrderViewModel>>
    {
        public Guid Uid { get; set; }
        public int OrderTypeId { get; set; }
        public int PaymentTypeId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public ICollection<OrderDetailCommand> OrderDetails { get; set; }
    }
}
