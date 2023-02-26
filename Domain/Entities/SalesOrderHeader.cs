using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SalesOrderHeader : AuditableEntity 
    {
        public string OrderNumber { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string PaymentType { get; set; }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set;}
    }
}
