using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class DeletePhysicalInventoryDocumentCommandValidator : AbstractValidator<DeletePhysicalInventoryDocumentCommand>
    {
        public DeletePhysicalInventoryDocumentCommandValidator()
        {
        }
    }
}
