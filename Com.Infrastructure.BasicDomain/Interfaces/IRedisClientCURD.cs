using Com.Infrastructure.BasicDomain.BasicInterfaces;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Interfaces
{
    public interface IRedisClientCURD<T, DTO> : ICommonRedisClient
                        where T : class, IEntity, IDTOTransfer<DTO>, new()
                          where DTO : class, IDTO, new()
    {

        //获取单个根据id
        Task<T> GetByIdAsync(string id);
        //获取多条 
        Task<IList<T>> GetByIdsAsync(System.Collections.ICollection ids);
        //分页获取多条 
        Task<IList<T>> GetALLAsync(int skipCount, int limitCount);
        //获取全部
        Task<IList<T>> GetALLAsync();
        //保存单个
        Task SaveAsync(T obj);
        //保存多个
        Task SavesAsync(IEnumerable<T> objs);
        //修改单个
        Task UpdateAsync(T obj);
        //修改多个
        Task UpdatesAsync(IEnumerable<T> objs);
        //删除单个
        Task DeleteAsync(string id);
        //删除多个
        Task DeletesAsync(System.Collections.ICollection ids);

    }
}
