using Application.Interfaces.Persistence;
using Application.Interfaces.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Infrastructure.Repositories
{
    public abstract class RepositoryBase<TSource> : IRepositoryBase<TSource> where TSource : class
    {
        protected readonly IApplicationContext _context;
        private readonly IDistributedCacheService _distributedCacheService;

        public RepositoryBase(IApplicationContext context, IDistributedCacheService distributedCacheService)
        {
            _context = context;
            _distributedCacheService = distributedCacheService;
        }

        public virtual void Add(TSource entity)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().Add(entity);
        }

        public virtual async Task AddAsync(TSource entity, CancellationToken cancellationToken = default)
        {
            await _distributedCacheService.RemoveDataAsync(typeof(TSource).FullName, cancellationToken);
            await _context.Set<TSource>().AddAsync(entity, cancellationToken);
        }

        public virtual void AddRange(IEnumerable<TSource> entities)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().AddRange(entities);
        }

        public virtual async Task AddRangeAsync(IEnumerable<TSource> entities, CancellationToken cancellationToken = default)
        {
            await _distributedCacheService.RemoveDataAsync(typeof(TSource).FullName, cancellationToken);
            await _context.Set<TSource>().AddRangeAsync(entities, cancellationToken);
        }

        public virtual TSource Get(Expression<Func<TSource, bool>> expression)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.FirstOrDefault(expression.Compile());

            var data = _context.Set<TSource>().FirstOrDefault(expression);
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual async Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.FirstOrDefault(expression.Compile());

            var data = await _context.Set<TSource>().FirstOrDefaultAsync(expression, cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual TSource GetByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).FirstOrDefault(expression.Compile());

            var data = _context.Set<TSource>().OrderByDescending(key).FirstOrDefault(expression);
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual async Task<TSource> GetByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).FirstOrDefault(expression.Compile());

            var data = await _context.Set<TSource>().OrderByDescending(key).FirstOrDefaultAsync(expression, cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual TSource GetLast<TKey>(Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.OrderBy(key.Compile()).LastOrDefault();

            var data = _context.Set<TSource>().OrderBy(key).LastOrDefault();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);
            
            return data;
        }

        public virtual TSource GetLast<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderBy(key.Compile()).LastOrDefault();

            var data = _context.Set<TSource>().Where(expression).OrderBy(key).LastOrDefault();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual TSource GetLastByDescending<TKey>(Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).LastOrDefault();

            var data = _context.Set<TSource>().OrderByDescending(key).LastOrDefault();
            return data;
        }

        public virtual TSource GetLastByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderByDescending(key.Compile()).LastOrDefault();

            var data = _context.Set<TSource>().Where(expression).OrderByDescending(key).LastOrDefault();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual async Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.OrderBy(key.Compile()).LastOrDefault();

            var data = await _context.Set<TSource>().OrderBy(key).LastOrDefaultAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderBy(key.Compile()).LastOrDefault();

            var data = await _context.Set<TSource>().Where(expression).OrderBy(key).LastOrDefaultAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).LastOrDefault();

            var data = await _context.Set<TSource>().OrderByDescending(key).LastOrDefaultAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderByDescending(key.Compile()).LastOrDefault();

            var data = await _context.Set<TSource>().Where(expression).OrderByDescending(key).LastOrDefaultAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual IEnumerable<TSource> GetAll()
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData;

            var data = _context.Set<TSource>().AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAll(Expression<Func<TSource, bool>> expression)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).AsEnumerable();

            var data = _context.Set<TSource>().Where(expression).AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.OrderBy(key.Compile()).AsEnumerable();

            var data = _context.Set<TSource>().OrderBy(key).AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderBy(key.Compile()).AsEnumerable();

            var data = _context.Set<TSource>().Where(expression).OrderBy(key).AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAllByDescending()
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Reverse().AsEnumerable();

            var data = _context.Set<TSource>().Reverse().AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAllByDescending(Expression<Func<TSource, bool>> expression)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).Reverse().AsEnumerable();

            var data = _context.Set<TSource>().Where(expression).Reverse().AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).AsEnumerable();

            var data = _context.Set<TSource>().OrderByDescending(key).AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key)
        {
            var cacheData = _distributedCacheService.GetData<IEnumerable<TSource>>(typeof(TSource).FullName);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderByDescending(key.Compile()).AsEnumerable();

            var data = _context.Set<TSource>().Where(expression).OrderByDescending(key).AsEnumerable();
            _distributedCacheService.SetData(typeof(TSource).FullName, data);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.ToList();

            var data = await _context.Set<TSource>().ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).ToList();

            var data = await _context.Set<TSource>().Where(expression).ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.OrderBy(key.Compile()).ToList();

            var data = await _context.Set<TSource>().OrderBy(key).ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderBy(key.Compile()).ToList();

            var data = await _context.Set<TSource>().Where(expression).OrderBy(key).ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllByDescendingAsync(CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Reverse().ToList();

            var data = await _context.Set<TSource>().Reverse().ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllByDescendingAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).Reverse().ToList();

            var data = await _context.Set<TSource>().Where(expression).Reverse().ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.OrderByDescending(key.Compile()).ToList();

            var data = await _context.Set<TSource>().OrderByDescending(key).ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual async Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default)
        {
            var cacheData = await _distributedCacheService.GetDataAsync<IEnumerable<TSource>>(typeof(TSource).FullName, cancellationToken);
            if (cacheData != null)
                return cacheData.Where(expression.Compile()).OrderByDescending(key.Compile()).ToList();

            var data = await _context.Set<TSource>().Where(expression).OrderByDescending(key).ToListAsync(cancellationToken);
            await _distributedCacheService.SetDataAsync(typeof(TSource).FullName, data, cancellationToken);

            return data;
        }

        public virtual void Remove(TSource entity)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TSource> entities)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().RemoveRange(entities);
        }

        public virtual void Update(TSource entity)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().Update(entity);
        }

        public virtual void UpdateRange(IEnumerable<TSource> entities)
        {
            _distributedCacheService.RemoveData(typeof(TSource).FullName);
            _context.Set<TSource>().UpdateRange(entities);
        }
    }
}
