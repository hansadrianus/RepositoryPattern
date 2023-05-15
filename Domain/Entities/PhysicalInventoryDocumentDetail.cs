using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhysicalInventoryDocumentDetail : AuditableEntity
    {
        public int PIDHeaderId { get; set; }
        public int ProductId { get; set; }
        public decimal? AdjustmentValuation { get; set; }
        public int? AdjustmentStock { get; set; }
        public DateTime? AdjustmentTime { get; set; }

        [ForeignKey("PIDHeaderId")]
        public PhysicalInventoryDocumentHeader PhysicalInventoryHeader { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
