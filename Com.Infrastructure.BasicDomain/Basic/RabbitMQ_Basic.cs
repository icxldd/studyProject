using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.BasicDomain.Basic
{
    public abstract class RabbitMQ_Basic
    {
        private readonly static IBus _bus = RabbitHutch.CreateBus("host=localhost");
        public IBus BusRabbitMQ { get; } = _bus;
    }
}
