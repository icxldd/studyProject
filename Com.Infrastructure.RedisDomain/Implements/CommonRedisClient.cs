using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Com.Infrastructure.BasicDomain.Basic;
using Com.Infrastructure.BasicDomain.Interfaces;

namespace Com.Infrastructure.BasicDomain.Implements
{
    public class CommonRedisClient : RedisClient_Basic, ICommonRedisClient
    {
        async public Task AddAsync(string key, object obj, DateTime? ExpireTime = null)
        {
            await Redis.AddAsync(key, obj);
        }

        async public Task AddListAsync(string key, string obj, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToListAsync(key, obj);
        }

        async public Task AddListsAsync(string key, List<string> obj, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToListAsync(key, obj);
        }

        async public Task AddSetAsync(string key, string obj, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToSetAsync(key, obj);
        }

        async public Task AddSetsAsync(string key, List<string> obj, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToSetAsync(key, obj);
        }

        async public Task AddToSortedSetAsync(string key, string obj, int score, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToSortedSetAsync(key, obj, score);
        }

        async public Task AddToSortedSetsAsync(string key, List<string> obj, int score, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToSortedSetAsync(key, obj, score);
        }

        async public Task IncrementKeyAsync(string key, int count)
        {
            await Redis.IncrementAsync(key, (uint)count);
        }

        async public Task DecrementKeyAsync(string key, int count)
        {
            await Redis.DecrementAsync(key, (uint)count);
        }

        async public Task<object> GetAsync(string key)
        {
            return await Redis.GetAsync<object>(key);
        }

        async public Task<IList<string>> GetALLKeysAsync()
        {
            return await Redis.GetAllKeysAsync();
        }

        async public Task<IList<string>> GetListAsync(string key)
        {
            return (await Redis.GetAllItemsFromListAsync(key));
        }

        async public Task<HashSet<string>> GetSetAsync(string key)
        {
            return (await Redis.GetAllItemsFromSetAsync(key));
        }

        async public Task<IList<string>> GetToSortSetAsync(string key)
        {
            return (await Redis.GetAllItemsFromSortedSetAsync(key));
        }

        async public Task<IList<string>> GetToSortSetByDescAsync(string key)
        {
            return (await Redis.GetAllItemsFromSortedSetDescAsync(key));
        }


        async public Task RemoveAsync(string key)
        {
            await Redis.RemoveAsync(key);
        }

        async public Task RemoveAllAsync(IEnumerable<string> keys)
        {
            await Redis.RemoveAllAsync(keys);
        }

        async public Task RemoveItemFromListAsync(string key, string val)
        {
            await Redis.RemoveItemFromListAsync(key, val);
        }

        async public Task RemoveItemFromSetAsync(string key, string val)
        {
            await Redis.RemoveItemFromSetAsync(key, val);
        }

        async public Task SetAsync(string key, string val, DateTime? ExpireTime = null)
        {
            await Redis.SetAsync(key, val);
        }

        async public Task SetAllAsync(IEnumerable<string> keys, IEnumerable<string> vals)
        {
            await Redis.SetAllAsync(keys, vals);
        }

        async public Task SetExpireEntryAtAsync(string key, DateTime ExpireTime)
        {
            await Redis.ExpireEntryAtAsync(key, ExpireTime);
        }
    }
}
