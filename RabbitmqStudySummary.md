## ѧϰ�ܽ�
1. bus.PubSub.Publish  //�������� && �����Խ��ܷ���
2. bus.Rpc.RequestAsync//�������� && ���Խ��ܷ���
3. bus.SendReceive.Send//�������� && �����Խ��ܷ���
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