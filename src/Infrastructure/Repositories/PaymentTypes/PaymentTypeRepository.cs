using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.PaymentTypes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.PaymentTypes
{
    public class PaymentTypeRepository : RepositoryBase<PaymentType>, IPaymentTypeRepository
    {
        public PaymentTypeRepository(IApplicationContext context) : base(context)
        {
        }
    }
}
