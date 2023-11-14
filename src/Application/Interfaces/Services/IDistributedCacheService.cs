namespace Application.Interfaces.Services
{
    public interface IDistributedCacheService
    {
        T GetData<T>(string key);
        Task<T> GetDataAsync<T>(string key, CancellationToken cancellationToken = default);
        void RemoveData(string key);
        Task RemoveDataAsync(string key, CancellationToken cancellationToken = default);
        void SetData<T>(string key, T value);
        void SetData<T>(string key, T value, DateTimeOffset expirationTime);
        Task SetDataAsync<T>(string key, T value, CancellationToken cancellationToken = default);
        Task SetDataAsync<T>(string key, T value, DateTimeOffset expirationTime, CancellationToken cancellationToken = default);
    }
}