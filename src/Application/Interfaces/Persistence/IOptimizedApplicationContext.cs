namespace Application.Interfaces.Persistence
{
    public interface IOptimizedApplicationContext
    {
        void ZBulkDelete(IEnumerable<object> entities);
        void ZBulkDelete(params object[] entities);
        Task ZBulkDeleteAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task ZBulkDeleteAsync(params object[] entities);
        void ZBulkExecute();
        Task ZBulkExecuteAsync(CancellationToken cancellationToken = default);
        void ZBulkInsert(IEnumerable<object> entities);
        void ZBulkInsert(params object[] entities);
        Task ZBulkInsertAsync(IEnumerable<object> entities);
        Task ZBulkInsertAsync(params object[] entities);
        void ZBulkMerge(IEnumerable<object> entities);
        void ZBulkMerge(params object[] entities);
        Task ZBulkMergeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task ZBulkMergeAsync(params object[] entities);
        void ZBulkSynchronize(IEnumerable<object> entities);
        void ZBulkSynchronize(params object[] entities);
        Task ZBulkSynchronizeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task ZBulkSynchronizeAsync(params object[] entities);
        void ZBulkUpdate(IEnumerable<object> entities);
        void ZBulkUpdate(params object[] entities);
        Task ZBulkUpdateAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default);
        Task ZBulkUpdateAsync(params object[] entities);
        void ZSingleDelete<TEntity>(TEntity entity);
        Task ZSingleDeleteAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default);
        void ZSingleInsert<TEntity>(TEntity entity);
        Task ZSingleInsertAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default);
        void ZSingleMerge<TEntity>(TEntity entity);
        Task ZSingleMergeAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default);
        void ZSingleSynchronize<TEntity>(TEntity entity);
        Task ZSingleSynchronizeAsync<TEntity>(TEntity entity, CancellationToken cancelltionToken = default);
        void ZSingleUpdate<TEntity>(TEntity entity);
        Task ZSingleUpdateAsync<TEntity>(TEntity entity, CancellationToken cancellationToken = default);
    }
}