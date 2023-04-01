using Application.Models;
using Application.ViewModels;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class AddSalesOrderCommand : IRequest<EndpointResult<SalesOrderViewModel>>
    {
        public int OrderTypeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentType { get; set; }
        public ICollection<OrderDetailCommand> OrderDetails { get; set; }
    }
}
