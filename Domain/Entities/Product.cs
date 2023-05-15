using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : AuditableEntity 
    {
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Valuation { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }

        public virtual ICollection<SalesOrderDetail>? SalesOrderDetails { get; set; }
        public virtual ICollection<PhysicalInventoryDocumentDetail>? PhysicalInventoryDetails { get; set; }
    }
}
