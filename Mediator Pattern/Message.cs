using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Pattern
{
    public class Message
    {
        public string From { get; }
        public string To { get; }
        public string Content { get; }

        public Message(string from, string to, string content)
        {
            From = from;
            To = to;
            Content = content;
        }
    }

}
