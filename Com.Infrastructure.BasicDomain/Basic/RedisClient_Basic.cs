using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.BasicDomain.Basic
{
    public abstract class RedisClient_Basic
    {
        private readonly static IRedisClientAsync redis = new RedisClient("localhost:6379");
        public IRedisClientAsync Redis { get; } = redis;
    }
}
