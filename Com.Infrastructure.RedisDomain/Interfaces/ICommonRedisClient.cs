using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Interfaces
{
    public interface ICommonRedisClient
    {
        //添加key value
        Task AddAsync(string key, object obj, DateTime? ExpireTime = null);
        //添加单个list
        Task AddListAsync(string key, string obj, DateTime? ExpireTime = null);
        //添加一组list
        Task AddListsAsync(string key, List<string> obj, DateTime? ExpireTime = null);
        //添加单个set 
        Task AddSetAsync(string key, string obj, DateTime? ExpireTime = null);
        //添加一组set
        Task AddSetsAsync(string key, List<string> obj, DateTime? ExpireTime = null);
        //添加单个自带排序set
        Task AddToSortedSetAsync(string key, string obj, int score, DateTime? ExpireTime = null);
        //添加一组自带排序set
        Task AddToSortedSetsAsync(string key, List<string> obj, int score, DateTime? ExpireTime = null);
        //设置失效时间
        Task SetExpireEntryAtAsync(string key, DateTime ExpireTime);
        Task<IList<string>> GetALLKeysAsync();
        //根据Key获取
        Task<object> GetAsync(string key);
        //根据key获取全部list
        Task<IList<string>> GetListAsync(string key);
        //根据key获取全部set
        Task<HashSet<string>> GetSetAsync(string key);
        //根据key顺序获取全部set
        Task<IList<string>> GetToSortSetAsync(string key);
        //根据key倒序获取全部set
        Task<IList<string>> GetToSortSetByDescAsync(string key);
        //根据key设置值
        Task SetAsync(string key, string val, DateTime? ExpireTime = null);
        //设置一组
        Task SetAllAsync(IEnumerable<string> keys, IEnumerable<string> vals);
        //删除单个
        Task RemoveAsync(string key);
        //删除一组
        Task RemoveAllAsync(IEnumerable<string> keys);
        //根据list val删除
        Task RemoveItemFromListAsync(string key, string val);
        //根据set val删除
        Task RemoveItemFromSetAsync(string key, string val);
        Task IncrementKeyAsync(string key, int count);
        Task DecrementKeyAsync(string key, int count);
    }
}
