using EasyNetQ;
using System;
using static classlibrary.Messages;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            //pubsub
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = "";
                Console.WriteLine("Enter a message. 'Quit' to quit.");
                while ((input = Console.ReadLine()) != "Quit")
                {

                    bus.PubSub.PublishAsync(new classlibrary.Messages.TextMessage
                    {
                        Text = input
                    });
                }
            }



            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = "";
                Console.WriteLine("Enter a message. 'Quit' to quit.");
                while ((input = Console.ReadLine()) != "Quit")
                {
                    bus.PubSub.PublishAsync(new classlibrary.Messages.TextMessage
                    {
                        Text = input
                    }, "X.A123");
                }
            }


            ////rpc
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = "";
                while ((input = Console.ReadLine()) != "Quit")
                {
                    var task = bus.Rpc.RequestAsync<TestRequestMessage, TestResponseMessage>(new TestRequestMessage() { Text = input });
                    task.ContinueWith(response =>
                    {
                        Console.WriteLine("Got response: '{0}'", response.Result.Text);
                    });
                }
            }


            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                var input = "";
                while ((input = Console.ReadLine()) != "Quit")
                {
                    bus.SendReceive.Send("my.queue", new TextMessage { Text = input });
                }
            }




            //using (var bus = RabbitHutch.CreateBus("host=localhost"))
            //{
            //    var input = "";
            //    while ((input = Console.ReadLine()) != "Quit")
            //    {
            //        bus.SendReceive.Send("my.queue", new TextMessage { Text = input });
            //    }
            //}
        }
    }
}
