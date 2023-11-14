using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.OrderTypes;
using Application.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.OrderTypes
{
    public class OrderTypeRepository : RepositoryBase<OrderType>, IOrderTypeRepository
    {
        public OrderTypeRepository(IApplicationContext context, IDistributedCacheService distributedCacheService) : base(context, distributedCacheService)
        {
        }
    }
}
