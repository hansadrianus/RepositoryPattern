using Application.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Infrastructure.Repositories
{
    public abstract class RepositoryBase<TSource> : IRepositoryBase<TSource> where TSource : class
    {
        protected readonly IApplicationContext _context;

        public RepositoryBase(IApplicationContext context)
        {
            _context = context;
        }

        public void Add(TSource entity)
            => _context.Set<TSource>().Add(entity);

        public async Task AddAsync(TSource entity, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().AddAsync(entity, cancellationToken);

        public void AddRange(IEnumerable<TSource> entities)
            => _context.Set<TSource>().AddRange(entities);

        public async Task AddRangeAsync(IEnumerable<TSource> entities, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().AddRangeAsync(entities, cancellationToken);

        public TSource Get(Expression<Func<TSource, bool>> expression)
            => _context.Set<TSource>().FirstOrDefault(expression);

        public async Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().FirstOrDefaultAsync(expression, cancellationToken);

        public TSource GetByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().OrderByDescending(key).FirstOrDefault(expression);

        public async Task<TSource> GetByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().OrderByDescending(key).FirstOrDefaultAsync(expression, cancellationToken);

        public TSource GetLast<TKey>(Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().OrderBy(key).LastOrDefault();

        public TSource GetLast<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().Where(expression).OrderBy(key).LastOrDefault();

        public TSource GetLastByDescending<TKey>(Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().OrderByDescending(key).LastOrDefault();

        public TSource GetLastByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().Where(expression).OrderByDescending(key).LastOrDefault();

        public async Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().OrderBy(key).LastOrDefaultAsync(cancellationToken);

        public async Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).OrderBy(key).LastOrDefaultAsync(cancellationToken);

        public async Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().OrderByDescending(key).LastOrDefaultAsync(cancellationToken);

        public async Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).OrderByDescending(key).LastOrDefaultAsync(cancellationToken);

        public IEnumerable<TSource> GetAll()
            => _context.Set<TSource>().AsEnumerable();

        public IEnumerable<TSource> GetAll(Expression<Func<TSource, bool>> expression)
            => _context.Set<TSource>().Where(expression).AsEnumerable();

        public IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().OrderBy(key).AsEnumerable();

        public IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().Where(expression).OrderBy(key).AsEnumerable();

        public IEnumerable<TSource> GetAllByDescending()
            => _context.Set<TSource>().Reverse().AsEnumerable();

        public IEnumerable<TSource> GetAllByDescending(Expression<Func<TSource, bool>> expression)
            => _context.Set<TSource>().Where(expression).Reverse().AsEnumerable();

        public IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().OrderByDescending(key).AsEnumerable();

        public IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
            => _context.Set<TSource>().Where(expression).OrderByDescending(key).AsEnumerable();

        public async Task<IEnumerable<TSource>> GetAllAsync(CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().OrderBy(key).ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).OrderBy(key).ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllByDescendingAsync(CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Reverse().ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllByDescendingAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).Reverse().ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().OrderByDescending(key).ToListAsync(cancellationToken);

        public async Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
            => await _context.Set<TSource>().Where(expression).OrderByDescending(key).ToListAsync(cancellationToken);

        public void Remove(TSource entity)
            => _context.Set<TSource>().Remove(entity);

        public void RemoveRange(IEnumerable<TSource> entities)
            => _context.Set<TSource>().RemoveRange(entities);

        public void Update(TSource entity)
            => _context.Set<TSource>().Update(entity);

        public void UpdateRange(IEnumerable<TSource> entities)
            => _context.Set<TSource>().UpdateRange(entities);
    }
}
