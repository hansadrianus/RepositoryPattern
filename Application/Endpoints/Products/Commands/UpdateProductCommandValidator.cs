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
                .NotEmpty();
            RuleFor(x => x.Price)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Stock)
                .NotEmpty()
                .GreaterThanOrEqualTo(0);
            RuleFor(x => x.Type)
                .NotEmpty();
        }
    }
}
