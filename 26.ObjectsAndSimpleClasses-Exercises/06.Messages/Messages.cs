using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Messages
{
    class Messages
    {
        static void Main()
        {
            var users = new Dictionary<string, User>();

            string input = Console.ReadLine();


            string sender;
            string recipient;

            while (input != "exit")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "register")
                {
                    string userName = tokens[1];

                    users.Add(userName, new User
                    {
                        UserName = userName,
                        RecievedMessages = new List<Message>()
                    });
                }
                else
                {
                    sender = tokens[0];
                    recipient = tokens[2];
                    string content = tokens[3];

                    if (users.ContainsKey(sender) && users.ContainsKey(recipient))
                    {
                        User senderName = users[sender];

                        users[recipient].RecievedMessages.Add(new Message
                        {
                            Content = content,
                            Sender = senderName
                        });
                    }
                }
                input = Console.ReadLine();
            }

            string[] chat = Console.ReadLine().Split(' ');
            
            sender = chat[0];
            recipient = chat[1];

            var senderMessages =
                users[recipient]
                .RecievedMessages
                .Where(m => m.Sender.UserName == sender)
                .ToArray();

            var recipientMessages =
                users[sender]
                .RecievedMessages
                .Where(m => m.Sender.UserName == recipient)
                .ToArray();

            int maxCount = Math.Max(senderMessages.Length, recipientMessages.Length);

            if (senderMessages.Length == 0 && recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            for (int i = 0; i < maxCount; i++)
            {
                if (i < senderMessages.Length)
                {
                    Console.WriteLine($"{sender}: {senderMessages[i].Content}");
                }

                if (i < recipientMessages.Length)
                {
                    Console.WriteLine($"{recipientMessages[i].Content} :{recipient}");
                }
            }
        }
        class User
        {
            public string UserName { get; set; }
            public List<Message> RecievedMessages { get; set; }
        }
        class Message
        {
            public string Content { get; set; }
            public User Sender { get; set; }
        }
    }
}
