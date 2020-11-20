using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using System.Linq;
using Com.Infrastructure.BasicDomain.Interfaces;
using Com.Infrastructure.BasicDomain.Basic;
using Com.Infrastructure.BasicDomain.BasicInterfaces;

namespace Com.Infrastructure.BasicDomain.Implements
{
    public sealed class RedisClientCURD<T, DTO> : CommonRedisClient, IRedisClientCURD<T, DTO>
          where T : class, IEntity, IDTOTransfer<DTO>, new()
                          where DTO : class, IDTO, new()
    {

        async public Task DeleteAsync(string id)
        {
            await Redis.DeleteByIdAsync<T>(id);
        }

        async public Task DeletesAsync(System.Collections.ICollection ids)
        {
            await Redis.DeleteByIdsAsync<T>(ids);
        }

        async public Task<T> GetByIdAsync(string id)
        {
            return await Redis.GetByIdAsync<T>(id);
        }

        async public Task<IList<T>> GetByIdsAsync(System.Collections.ICollection ids)
        {
            return await Redis.GetByIdsAsync<T>(ids);
        }

        async public Task<IList<T>> GetALLAsync(int skipCount, int limitCount)
        {
            var table = Redis.As<T>();
            var list = await table.GetAllAsync();
            return list.Skip(skipCount).Take(limitCount).ToList();
        }
        async public Task<IList<T>> GetALLAsync()
        {
            var table = Redis.As<T>();
            var list = await table.GetAllAsync();
            return list;
        }
        async public Task SaveAsync(T obj)
        {
            await Redis.StoreAsync<T>(obj);
        }

        async public Task SavesAsync(IEnumerable<T> objs)
        {
            await Redis.StoreAllAsync<T>(objs);
        }

        async public Task UpdateAsync(T obj)
        {
            await Redis.StoreAsync<T>(obj);
        }

        async public Task UpdatesAsync(IEnumerable<T> objs)
        {
            await Redis.StoreAllAsync<T>(objs);
        }
    }
}
