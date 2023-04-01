using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record SalesOrderViewModel
    {
        public string OrderNumber { get; set; }
        public int OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentType { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public record OrderDetail
        {
            public int ProductId { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public DateTime DeliveryDate { get; set; }
            public string Notes { get; set; }
        }
    }
}
