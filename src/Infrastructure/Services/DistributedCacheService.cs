using Application.Interfaces.Services;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class DistributedCacheService : IDistributedCacheService
    {
        private readonly IDistributedCache _cache;
        private readonly DateTimeOffset _expireTime;

        public DistributedCacheService(IDistributedCache cache, IConfiguration configuration)
        {
            _cache = cache;
            _expireTime = DateTimeOffset.Now.AddHours(configuration.GetValue<double>("CacheExpiryTimeInHour"));
        }

        public T GetData<T>(string key)
        {
            var data = _cache.GetString(key);
            if (string.IsNullOrEmpty(data))
                return default(T);

            return JsonConvert.DeserializeObject<T>(data);
        }

        public async Task<T> GetDataAsync<T>(string key, CancellationToken cancellationToken = default)
        {
            var data = await _cache.GetStringAsync(key, cancellationToken);
            if (string.IsNullOrEmpty(data))
                return default(T);

            return JsonConvert.DeserializeObject<T>(data);
        }

        public void RemoveData(string key)
        {
            if (_cache.GetString(key).Any())
                _cache.Remove(key);
        }

        public async Task RemoveDataAsync(string key, CancellationToken cancellationToken = default)
        {
            if (_cache.GetString(key).Any())
                await _cache.RemoveAsync(key, cancellationToken);
        }

        public void SetData<T>(string key, T value)
        {
            TimeSpan expiryTime = _expireTime.DateTime.Subtract(DateTime.Now);
            var options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = expiryTime
            };

            var json = JsonConvert.SerializeObject(value);
            _cache.SetString(key, json, options);
        }

        public async Task SetDataAsync<T>(string key, T value, CancellationToken cancellationToken = default)
        {
            TimeSpan expiryTime = _expireTime.DateTime.Subtract(DateTime.Now);
            var options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = expiryTime
            };

            var json = JsonConvert.SerializeObject(value);
            await _cache.SetStringAsync(key, json, options, cancellationToken);
        }

        public void SetData<T>(string key, T value, DateTimeOffset expirationTime)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = expiryTime
            };

            var json = JsonConvert.SerializeObject(value);
            _cache.SetString(key, json, options);
        }

        public async Task SetDataAsync<T>(string key, T value, DateTimeOffset expirationTime, CancellationToken cancellationToken = default)
        {
            TimeSpan expiryTime = expirationTime.DateTime.Subtract(DateTime.Now);
            var options = new DistributedCacheEntryOptions()
            {
                AbsoluteExpirationRelativeToNow = expiryTime
            };

            var json = JsonConvert.SerializeObject(value);
            await _cache.SetStringAsync(key, json, options, cancellationToken);
        }
    }
}
