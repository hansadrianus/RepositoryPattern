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
    public class DeletePhysicalInventoryDocumentCommand : IRequest<EndpointResult<PhysicalInventoryDocumentViewModel>>
    {
        public int Id { get; set; }
    }
}
