using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.SalesOrders;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.SalesOrders
{
    public class SalesOrderRepository : RepositoryBase<SalesOrderHeader>, ISalesOrderRepository
    {
        public SalesOrderRepository(IApplicationContext context) : base(context)
        {
        }
    }
}
