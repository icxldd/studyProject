using Com.Infrastructure.BasicDomain.Basic;
using Com.Infrastructure.BasicDomain.Interfaces;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Implements
{
    public class ElasticClient : ElasticClient_Basic, Interfaces.IElasticClient
    {
        async public Task CreateAsync<T>(T document, Func<Nest.CreateDescriptor<T>, Nest.ICreateRequest<T>> f) where T : class
        {
            await client.CreateAsync(document, f);
        }

        async public Task<GetResponse<T>> GetAsync<T>(Nest.DocumentPath<T> id, Func<Nest.GetDescriptor<T>, Nest.IGetRequest> f) where T : class
        {
            return await client.GetAsync(id, f);
        }

        async public Task RemoveAsync<T>(Nest.DocumentPath<T> id, Func<Nest.DeleteDescriptor<T>, Nest.IDeleteRequest> f) where T : class
        {
            await client.DeleteAsync(id, f);
        }

        async public Task<ISearchResponse<T>> SearchAsync<T>(Func<SearchDescriptor<T>, ISearchRequest> f) where T : class
        {
            return await client.SearchAsync(f);
        }

        async public Task UpdateAsync<T>(T document, Func<Nest.IndexDescriptor<T>, Nest.IIndexRequest<T>> f) where T : class
        {
            await client.IndexAsync(document, f);
        }
    }
}
