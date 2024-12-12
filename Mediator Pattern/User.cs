using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class User
    {
        public string Name { get; }
        private ChatMediator _mediator; 
        public List<Message> MessageHistory { get; private set; }

        public User(string name, ChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
            MessageHistory = new List<Message>();
        }

        public void SendMessage(string to, string content)
        {
            var message = new Message(Name, to, content);
            _mediator.SendMessage(message);
        }

        public void ReceiveMessage(Message message)
        {
            MessageHistory.Add(message);
            Console.WriteLine($"[{Name} получил сообщение от {message.From}]: {message.Content}");
        }
    }
}
