using Com.Infrastructure.BasicDomain.Basic;
using Com.Infrastructure.BasicDomain.Interfaces;
using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Infrastructure.BasicDomain.Implements
{
    public class CommonRabbitMQ : RabbitMQ_Basic, ICommonRabbitMQ
    {
        async public Task PublishPubSubAsync<T>(T data)
        {
            await BusRabbitMQ.PubSub.PublishAsync(data);
        }

        async public Task PublishPubSubAsync<T>(T data, string topic)
        {
            await BusRabbitMQ.PubSub.PublishAsync(data, topic);
        }

        async public Task<Response> PublishRPCAsync<Request, Response>(Request r)
        {
            return await BusRabbitMQ.Rpc.RequestAsync<Request, Response>(r);
        }

        async public Task PublishSend<T>(string queue, T data)
        {
            await BusRabbitMQ.SendReceive.SendAsync(queue, data);
        }

        async public Task SubscribePubSubAsync<T>(string subId, Action<T> action)
        {
            await BusRabbitMQ.PubSub.SubscribeAsync<T>(subId, action);
        }

        async public Task SubscribePubSubAsync<T>(string subId, Action<T> action, Action<ISubscriptionConfiguration> config)
        {
            await BusRabbitMQ.PubSub.SubscribeAsync<T>(subId, action, config);
        }

        async public Task SubscribeRpcAsync<Request, Response>(Func<Request, Response> onexec)
        {
            await BusRabbitMQ.Rpc.RespondAsync<Request, Response>(onexec);
        }

        async public Task SubscribeSendAsync<T>(string queue, Action<T> action)
        {
            await BusRabbitMQ.SendReceive.ReceiveAsync<T>(queue, action);
        }
    }
}
