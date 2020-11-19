## 学习总结
1. bus.PubSub.Publish  //多条消费 && 不可以接受返回
2. bus.Rpc.RequestAsync//单条消费 && 可以接受返回
3. bus.SendReceive.Send//单条消费 && 不可以接受返回
4. topic  
	* ```
	 bus.PubSub.Publish(new classlibrary.Messages.TextMessage
                    {
                        Text = input
                    }, "X.A123");
	  ```
	* ```
		bus.PubSub.Subscribe<TextMessage>("test", HandleTextMessage2, x => x.WithTopic("X.*"));
	  ```