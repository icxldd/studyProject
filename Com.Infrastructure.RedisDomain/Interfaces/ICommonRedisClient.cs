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
        Task Add(string key, object obj, DateTime? ExpireTime = null);
        //添加单个list
        Task AddList(string key, string obj, DateTime? ExpireTime = null);
        //添加一组list
        Task AddLists(string key, List<string> obj, DateTime? ExpireTime = null);
        //添加单个set 
        Task AddSet(string key, string obj, DateTime? ExpireTime = null);
        //添加一组set
        Task AddSets(string key, List<string> obj, DateTime? ExpireTime = null);
        //添加单个自带排序set
        Task AddToSortedSet(string key, string obj, int score, DateTime? ExpireTime = null);
        //添加一组自带排序set
        Task AddToSortedSets(string key, List<string> obj, int score, DateTime? ExpireTime = null);
        //设置失效时间
        Task SetExpireEntryAt(string key, DateTime ExpireTime);
        Task<IList<string>> GetALLKeys();
        //根据Key获取
        Task<object> Get(string key);
        //根据key获取全部list
        Task<IList<string>> GetList(string key);
        //根据key获取全部set
        Task<HashSet<string>> GetSet(string key);
        //根据key顺序获取全部set
        Task<IList<string>> GetToSortSet(string key);
        //根据key倒序获取全部set
        Task<IList<string>> GetToSortSetByDesc(string key);
        //根据key设置值
        Task Set(string key, string val, DateTime? ExpireTime = null);
        //设置一组
        Task SetAll(IEnumerable<string> keys, IEnumerable<string> vals);
        //删除单个
        Task Remove(string key);
        //删除一组
        Task RemoveAll(IEnumerable<string> keys);
        //根据list val删除
        Task RemoveItemFromList(string key, string val);
        //根据set val删除
        Task RemoveItemFromSet(string key, string val);

        Task IncrementKey(string key, int count);
        Task DecrementKey(string key, int count);


    }
}
