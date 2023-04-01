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
            RuleFor(x => x.OrderTypeId)
                .NotEmpty()
                .NotNull()
                .GreaterThan(0);
            RuleFor(x => x.PaymentType)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.OrderDate)
                .NotEmpty()
                .NotNull()
                .GreaterThanOrEqualTo(DateTime.Now);
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
