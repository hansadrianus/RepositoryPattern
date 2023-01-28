using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class AddSalesOrderCommandValidator : AbstractValidator<AddSalesOrderCommand>
    {
        public AddSalesOrderCommandValidator()
        {
            RuleFor(x => x.OrderType)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.PaymentType)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.OrderDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.UtcNow);
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
