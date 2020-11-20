using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Interfaces
{
    public interface IElasticClient
    {
        Task CreateAsync<T>(T document, Func<CreateDescriptor<T>, ICreateRequest<T>> f) where T : class;
        Task UpdateAsync<T>(T document, Func<IndexDescriptor<T>, IIndexRequest<T>> f) where T : class;
        Task<GetResponse<T>> GetAsync<T>(DocumentPath<T> id, Func<GetDescriptor<T>, IGetRequest> f) where T : class;
        Task<ISearchResponse<T>> SearchAsync<T>(Func<SearchDescriptor<T>, ISearchRequest> f) where T : class;
        Task RemoveAsync<T>(DocumentPath<T> id, Func<DeleteDescriptor<T>, IDeleteRequest> f) where T : class;
    }
}
