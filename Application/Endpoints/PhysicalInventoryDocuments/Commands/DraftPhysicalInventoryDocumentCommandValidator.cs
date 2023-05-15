﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class DraftPhysicalInventoryDocumentCommandValidator : AbstractValidator<DraftPhysicalInventoryDocumentCommand>
    {
        public DraftPhysicalInventoryDocumentCommandValidator()
        {
            RuleFor(x => x.Evaluator)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PhysicalInventoryDocumentDetails)
                .NotEmpty()
                .NotNull();
        }
    }
}
