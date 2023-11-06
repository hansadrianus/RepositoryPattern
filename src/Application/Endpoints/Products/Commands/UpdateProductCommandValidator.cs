using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.Products.Commands
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Valuation)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Price)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Stock)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Type)
                .NotNull()
                .NotEmpty();
        }
    }
}
