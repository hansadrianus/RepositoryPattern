using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record PhysicalInventoryDocumentViewModel
    {
        public Guid Uid { get; set; }
        public string DocumentNo { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public string Evaluator { get; set; }
        public string? Notes { get; set; }
        public bool IsDraft { get; set; }
        public ICollection<PhysicalInventoryDocumentDetailViewModel> PhysicalInventoryDocumentDetails { get; set; }

        public record PhysicalInventoryDocumentDetailViewModel()
        {
            public Guid Uid { get; set; }
            public int PIDHeaderId { get; set; }
            public int ProductId { get; set; }
            public decimal? AdjustmentValuation { get; set; }
            public int? AdjustmentStock { get; set; }
            public DateTime? AdjustmentTime { get; set; }
        }
    }
}
