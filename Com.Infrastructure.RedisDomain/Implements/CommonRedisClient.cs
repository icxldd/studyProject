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
        async public Task Add(string key, object obj, DateTime? ExpireTime = null)
        {
            await Redis.AddAsync(key, obj);
        }

        async public Task AddList(string key, string obj, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToListAsync(key, obj);
        }

        async public Task AddLists(string key, List<string> obj, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToListAsync(key, obj);
        }

        async public Task AddSet(string key, string obj, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToSetAsync(key, obj);
        }

        async public Task AddSets(string key, List<string> obj, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToSetAsync(key, obj);
        }

        async public Task AddToSortedSet(string key, string obj, int score, DateTime? ExpireTime = null)
        {
            await Redis.AddItemToSortedSetAsync(key, obj, score);
        }

        async public Task AddToSortedSets(string key, List<string> obj, int score, DateTime? ExpireTime = null)
        {
            await Redis.AddRangeToSortedSetAsync(key, obj, score);
        }

        async public Task IncrementKey(string key, int count)
        {
            await Redis.IncrementAsync(key, (uint)count);
        }

        async public Task DecrementKey(string key, int count)
        {
            await Redis.DecrementAsync(key, (uint)count);
        }

        async public Task<object> Get(string key)
        {
            return await Redis.GetAsync<object>(key);
        }

        async public Task<IList<string>> GetALLKeys()
        {
            return await Redis.GetAllKeysAsync();
        }

        async public Task<IList<string>> GetList(string key)
        {
            return (await Redis.GetAllItemsFromListAsync(key));
        }

        async public Task<HashSet<string>> GetSet(string key)
        {
            return (await Redis.GetAllItemsFromSetAsync(key));
        }

        async public Task<IList<string>> GetToSortSet(string key)
        {
            return (await Redis.GetAllItemsFromSortedSetAsync(key));
        }

        async public Task<IList<string>> GetToSortSetByDesc(string key)
        {
            return (await Redis.GetAllItemsFromSortedSetDescAsync(key));
        }


        async public Task Remove(string key)
        {
            await Redis.RemoveAsync(key);
        }

        async public Task RemoveAll(IEnumerable<string> keys)
        {
            await Redis.RemoveAllAsync(keys);
        }

        async public Task RemoveItemFromList(string key, string val)
        {
            await Redis.RemoveItemFromListAsync(key, val);
        }

        async public Task RemoveItemFromSet(string key, string val)
        {
            await Redis.RemoveItemFromSetAsync(key, val);
        }

        async public Task Set(string key, string val, DateTime? ExpireTime = null)
        {
            await Redis.SetAsync(key, val);
        }

        async public Task SetAll(IEnumerable<string> keys, IEnumerable<string> vals)
        {
            await Redis.SetAllAsync(keys, vals);
        }

        async public Task SetExpireEntryAt(string key, DateTime ExpireTime)
        {
            await Redis.ExpireEntryAtAsync(key, ExpireTime);
        }
    }
}
