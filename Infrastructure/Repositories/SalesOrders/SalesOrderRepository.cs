using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.SalesOrders;
using Application.ViewModels;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.SalesOrders
{
    public class SalesOrderRepository : RepositoryBase<SalesOrderHeader>, ISalesOrderRepository
    {
        private readonly IApplicationContext _context;

        public SalesOrderRepository(IApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<SalesOrderHeader>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SalesOrderHeader.Include(q => q.SalesOrderDetails).ToListAsync(cancellationToken);
        }

        public override async Task<IEnumerable<SalesOrderHeader>> GetAllAsync(Expression<Func<SalesOrderHeader, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await _context.SalesOrderHeader.Include(q => q.SalesOrderDetails).Where(expression).ToListAsync(cancellationToken);
        }
    }
}
