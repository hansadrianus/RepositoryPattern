using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class PhysicalInventoryDocumentDetailCommand
    {
        public int PIDHeaderId { get; set; }
        public int ProductId { get; set; }
        public decimal? AdjustmentValuation { get; set; }
        public int? AdjustmentStock { get; set; }
        public DateTime? AdjustmentTime { get; set; }
    }
}
