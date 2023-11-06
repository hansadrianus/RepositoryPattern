using Application.Models;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Endpoints.PaymentTypes.Queries
{
    public class GetPaymentTypeQuery : IRequest<EndpointResult<IEnumerable<PaymentTypeViewModel>>>
    {
    }
}
