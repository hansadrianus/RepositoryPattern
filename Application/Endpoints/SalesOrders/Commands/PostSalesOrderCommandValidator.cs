using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class PostSalesOrderCommandValidator : AbstractValidator<PostSalesOrderCommand>
    {
        public PostSalesOrderCommandValidator()
        {
            RuleFor(x => x.OrderTypeId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.PaymentTypeId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.CustomerName)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.CustomerAddress)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.OrderDetails)
                .NotEmpty()
                .NotNull();
        }
    }
}
