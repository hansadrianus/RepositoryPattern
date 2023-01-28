using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.SalesOrders.Commands
{
    public class DeleteSalesOrderCommandValidator : AbstractValidator<DeleteSalesOrderCommand>
    {
        public DeleteSalesOrderCommandValidator()
        { 
        }
    }
}
