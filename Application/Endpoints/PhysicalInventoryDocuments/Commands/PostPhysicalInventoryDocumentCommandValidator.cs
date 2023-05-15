using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PhysicalInventoryDocuments.Commands
{
    public class PostPhysicalInventoryDocumentCommandValidator : AbstractValidator<PostPhysicalInventoryDocumentCommand>
    {
        public PostPhysicalInventoryDocumentCommandValidator()
        {
            RuleFor(x => x.PlanStartDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Parse(DateTime.Now.ToShortDateString()));
            RuleFor(x => x.PlanFinishDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Parse(DateTime.Now.ToShortDateString()));
            RuleFor(x => x.Evaluator)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PhysicalInventoryDocumentDetails)
                .NotEmpty()
                .NotNull();
        }
    }
}
