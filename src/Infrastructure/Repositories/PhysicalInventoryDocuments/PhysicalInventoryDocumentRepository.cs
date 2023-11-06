using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.PhysicalInventoryDocuments;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.PhysicalInventoryDocuments
{
    public class PhysicalInventoryDocumentRepository : RepositoryBase<PhysicalInventoryDocumentHeader>, IPhysicalInventoryDocumentRepository
    {
        private readonly IApplicationContext _context;

        public PhysicalInventoryDocumentRepository(IApplicationContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<PhysicalInventoryDocumentHeader>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.PhysicalInventoryDocumentHeader.Include(q => q.PhysicalInventoryDetails).ToListAsync(cancellationToken);
        }

        public override async Task<IEnumerable<PhysicalInventoryDocumentHeader>> GetAllAsync(Expression<Func<PhysicalInventoryDocumentHeader, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await _context.PhysicalInventoryDocumentHeader.Include(q => q.PhysicalInventoryDetails).Where(expression).ToListAsync(cancellationToken);
        }
    }
}
