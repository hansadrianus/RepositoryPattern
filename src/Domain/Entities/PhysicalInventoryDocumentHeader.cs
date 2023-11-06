using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhysicalInventoryDocumentHeader : AuditableEntity
    {
        public string? DocumentNo { get; set; }
        public DateTime DocumentDate { get; set; }
        public DateTime? PostingDate { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public string Evaluator { get; set; }
        public string? Notes { get; set; }
        public bool IsDraft { get; set; }

        public virtual ICollection<PhysicalInventoryDocumentDetail> PhysicalInventoryDetails { get; set; }
    }
}
