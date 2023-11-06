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
    public class GetSalesOrderByDetailQuery : IRequest<EndpointResult<IEnumerable<SalesOrderViewModel>>>
    {
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? Notes { get; set; }
    }
}
