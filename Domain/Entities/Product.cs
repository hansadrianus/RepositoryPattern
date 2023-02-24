using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product<TKey> : AuditableEntity<TKey> where TKey : IEquatable<TKey>
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SalesOrderDetail<TKey>>? SalesOrderDetails { get; set; }
    }
}
