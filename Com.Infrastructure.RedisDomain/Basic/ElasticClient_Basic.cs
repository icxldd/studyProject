using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Infrastructure.BasicDomain.Basic
{
    public abstract class ElasticClient_Basic
    {
        static Uri node = new Uri("http://116.62.190.90:9200");
        static ConnectionSettings settings = new ConnectionSettings(node);
        protected static ElasticClient client = new ElasticClient(settings);


    }
}
