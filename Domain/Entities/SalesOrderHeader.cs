using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SalesOrderHeader : AuditableEntity 
    {
        public string? OrderNumber { get; set; }
        public int OrderTypeId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public int PaymentTypeId { get; set; }
        public bool IsDraft { get; set; }

        [ForeignKey("OrderTypeId")]
        public OrderType OrderType { get; set; }
        [ForeignKey("PaymentTypeId")]
        public PaymentType PaymentType { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set;}
    }
}
