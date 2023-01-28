using Application.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly IApplicationContext _context;

        public RepositoryBase(IApplicationContext context)
        {
            _context = context;
        }

        public void Add(T entity)
            => _context.Set<T>().Add(entity);

        public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
            => await _context.Set<T>().AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<T> entities)
            => _context.Set<T>().AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken = default)
            => await _context.Set<T>().AddRangeAsync(entities, cancellationToken);

        public T Get(Expression<Func<T, bool>> expression)
            => _context.Set<T>().FirstOrDefault(expression);

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => await _context.Set<T>().FirstOrDefaultAsync(expression, cancellationToken);

        public T GetLast(Expression<Func<T, bool>> expression)
            => _context.Set<T>().Where(expression).AsEnumerable().LastOrDefault();

        public async Task<T> GetLastAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => (await _context.Set<T>().Where(expression).ToListAsync(cancellationToken)).LastOrDefault();

        public IEnumerable<T> GetAll()
            => _context.Set<T>().AsEnumerable();

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> expression)
            => _context.Set<T>().Where(expression).AsEnumerable();

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Set<T>().ToListAsync(cancellationToken);

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, CancellationToken cancellationToken = default)
            => await _context.Set<T>().Where(expression).ToListAsync(cancellationToken);

        public void Remove(T entity)
            => _context.Set<T>().Remove(entity);

        public void RemoveRange(IEnumerable<T> entities)
            => _context.Set<T>().RemoveRange(entities);

        public void Update(T entity)
            => _context.Set<T>().Update(entity);

        public void UpdateRange(IEnumerable<T> entities)
            => _context.Set<T>().UpdateRange(entities);
    }
}
