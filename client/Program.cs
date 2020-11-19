using Com.Infrastructure.BasicDomain.Implements;
using Com.Infrastructure.BasicDomain.Interfaces;
using Com.Infrastructure.Entitys.Entitys;
using EasyNetQ;
using System;
using System.Collections.Concurrent;
using static classlibrary.Messages;
using Newtonsoft.Json;
using Com.Infrastructure.Entitys.Dtos;

namespace client
{
    class Program
    {
        private static ICommonRabbitMQ _CommonRabbitMQ = new CommonRabbitMQ();
        static void print(string text)
        {
            Console.WriteLine(text + "\n");
        }
        static void Main(string[] args)
        {

            _CommonRabbitMQ.SubscribePubSubAsync<Account>("1", x =>
            {
                print("subid:1" + JsonConvert.SerializeObject(x));
            });

            _CommonRabbitMQ.SubscribePubSubAsync<Account>("2", x =>
            {
                print("subid:2" + JsonConvert.SerializeObject(x));
            });

            _CommonRabbitMQ.SubscribePubSubAsync<Account>("3", x =>
            {
                print("subtopicid:1" + JsonConvert.SerializeObject(x));
            }, x => x.WithTopic("icxl"));

            _CommonRabbitMQ.SubscribePubSubAsync<Account>("4", x =>
            {
                print("subtopicid:2" + JsonConvert.SerializeObject(x));
            }, x => x.WithTopic("icxl"));

            _CommonRabbitMQ.SubscribeRpcAsync<Account, AccountDTO>((x) =>
            {
                print("rpc:" + JsonConvert.SerializeObject(x));
                return x.ToDTO();
            });
            _CommonRabbitMQ.SubscribeSendAsync<Account>("icxl", x =>
            {
                print("send:" + JsonConvert.SerializeObject(x));
            });


            Console.WriteLine("Listening for messages. Hit <return> to quit.");
            Console.ReadLine();


            //using (var bus = RabbitHutch.CreateBus("host=localhost"))
            //{
            //    bus.PubSub.Subscribe<TextMessage>("test", HandleTextMessage);
            //    bus.PubSub.Subscribe<TextMessage>("test1", HandleTextMessage2);
            //    Console.WriteLine("Listening for messages. Hit <return> to quit.");
            //    Console.ReadLine();
            //}



            //using (var bus = RabbitHutch.CreateBus("host=localhost"))
            //{
            //    bus.PubSub.SubscribeAsync<TextMessage>("test", HandleTextMessage, x => x.WithTopic("X.*"));


            //    bus.PubSub.SubscribeAsync<TextMessage>("test2", HandleTextMessage2, x => x.WithTopic("X.*"));
            //    Console.WriteLine("Listening for messages. Hit <return> to quit.");
            //    Console.ReadLine();
            //}


            //using (var bus = RabbitHutch.CreateBus("host=localhost"))
            //{

            //    bus.Rpc.Respond<TestRequestMessage, TestResponseMessage>(request =>
            //    {

            //        HandleTextMessage3(request);
            //        return new TestResponseMessage() { Text = "Responding to " + request.Text };
            //    }
            //    );


            //    bus.Rpc.Respond<TestRequestMessage, TestResponseMessage>(request =>
            //    {

            //        HandleTextMessage4(request);
            //        return new TestResponseMessage() { Text = "Responding to " + request.Text };
            //    }
            //   );
            //    Console.WriteLine("Listening for messages. Hit <return> to quit.");
            //    Console.ReadLine();
            //}


            //using (var bus = RabbitHutch.CreateBus("host=localhost"))
            //{

            //    bus.SendReceive.Receive<TextMessage>("my.queue", message => Console.WriteLine("MyMessage: {0}", message.Text));
            //    bus.SendReceive.Receive<TextMessage>("my.queue", message => Console.WriteLine("MyMessage2: {0}", message.Text));
            //    Console.WriteLine("Listening for messages. Hit <return> to quit.");
            //    Console.ReadLine();
            //}

            ////using (var bus = RabbitHutch.CreateBus("host=localhost"))
            ////{

            ////    bus.SendReceive.Receive<TextMessage>("my.queue", message => Console.WriteLine("MyMessage: {0}", message.Text));
            ////    bus.SendReceive.Receive<TextMessage>("my.queue", message => Console.WriteLine("MyMessage2: {0}", message.Text));
            ////    Console.WriteLine("Listening for messages. Hit <return> to quit.");
            ////    Console.ReadLine();
            ////}



            //static void HandleTextMessage(TextMessage textMessage)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Got message: {0}", textMessage.Text);
            //    Console.ResetColor();
            //}


            //static void HandleTextMessage2(TextMessage textMessage)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Got message2: {0}", textMessage.Text);
            //    Console.ResetColor();
            //}

            //static void HandleTextMessage3(TestRequestMessage textMessage)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Got message3: {0}", textMessage.Text);
            //    Console.ResetColor();
            //}

            //static void HandleTextMessage4(TestRequestMessage textMessage)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Got message4: {0}", textMessage.Text);
            //    Console.ResetColor();
            //}


        }
    }
}
