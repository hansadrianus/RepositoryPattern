using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class DraftPhysicalInventoryDocumentCommand : IRequest<EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanFinishDate { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualFinishDate { get; set; }
        public string Evaluator { get; set; }
        public string? Notes { get; set; }
        public ICollection<PhysicalInventoryDocumentDetailCommand> PhysicalInventoryDocumentDetails { get; set; }
    }
}
