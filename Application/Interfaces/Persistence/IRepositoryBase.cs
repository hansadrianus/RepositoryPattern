using System.Linq.Expressions;

namespace Application.Interfaces.Persistence
{
    public interface IRepositoryBase<TSource> where TSource : class
    {
        void Add(TSource entity);
        Task AddAsync(TSource entity, CancellationToken cancellationToken = default);
        void AddRange(IEnumerable<TSource> entities);
        Task AddRangeAsync(IEnumerable<TSource> entities, CancellationToken cancellationToken = default);
        TSource Get(Expression<Func<TSource, bool>> expression);
        IEnumerable<TSource> GetAll();
        IEnumerable<TSource> GetAll(Expression<Func<TSource, bool>> expression);
        IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key);
        IEnumerable<TSource> GetAll<TKey>(Expression<Func<TSource, TKey>> key);
        Task<IEnumerable<TSource>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        IEnumerable<TSource> GetAllByDescending();
        IEnumerable<TSource> GetAllByDescending(Expression<Func<TSource, bool>> expression);
        IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key);
        IEnumerable<TSource> GetAllByDescending<TKey>(Expression<Func<TSource, TKey>> key);
        Task<IEnumerable<TSource>> GetAllByDescendingAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllByDescendingAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        Task<IEnumerable<TSource>> GetAllByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        Task<TSource> GetAsync(Expression<Func<TSource, bool>> expression, CancellationToken cancellationToken = default);
        TSource GetByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key);
        Task<TSource> GetByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        TSource GetLast<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key);
        TSource GetLast<TKey>(Expression<Func<TSource, TKey>> key);
        Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        Task<TSource> GetLastAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        TSource GetLastByDescending<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key);
        TSource GetLastByDescending<TKey>(Expression<Func<TSource, TKey>> key);
        Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        Task<TSource> GetLastByDescendingAsync<TKey>(Expression<Func<TSource, TKey>> key, CancellationToken cancellationToken = default);
        void Remove(TSource entity);
        void RemoveRange(IEnumerable<TSource> entities);
        void Update(TSource entity);
        void UpdateRange(IEnumerable<TSource> entities);
    }
}