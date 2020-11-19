using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Interfaces
{
    public interface ICommonRabbitMQ
    {
        //发布订阅模式
        Task PublishPubSubAsync<T>(T data);

        //发布订阅模式topic
        Task PublishPubSubAsync<T>(T data, string topic);
        //发布request response
        Task<Response> PublishRPCAsync<Request, Response>(Request r);
        //发布tcp
        Task PublishSend<T>(string queue, T data);
        //监听订阅
        Task SubscribePubSubAsync<T>(string subId, Action<T> action);
        //监听订阅topic
        Task SubscribePubSubAsync<T>(string subId, Action<T> action, Action<ISubscriptionConfiguration> config);
        //监听request response
        Task SubscribeRpcAsync<Request, Response>(Func<Request, Response> onexec);
        //监听tcp
        Task SubscribeSendAsync<T>(string queue, Action<T> action);

    }
}
