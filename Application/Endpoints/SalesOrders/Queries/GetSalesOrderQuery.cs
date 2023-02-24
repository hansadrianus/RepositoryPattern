using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Queries
{
    public class GetSalesOrderQuery : IRequest<EndpointResult<IEnumerable<SalesOrderViewModel>>>
    {
        public int? Id { get; set; }
        public string? OrderNumber { get; set; }
        public string? OrderType { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? PaymentType { get; set; }
        public DateTime? OrderDate_GreaterThanEqual { get; set; }
        public DateTime? OrderDate_LessThanEqual { get; set; }
    }
}
