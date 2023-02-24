using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SalesOrderDetail<TKey> : AuditableEntity<TKey> where TKey : IEquatable<TKey>
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Notes { get; set; }

        [ForeignKey("OrderId")]
        public virtual SalesOrderHeader<TKey> OrderHeader { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product<TKey> Product { get; set; }
    }
}
