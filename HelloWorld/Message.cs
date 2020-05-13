using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Message
    {
        private string _message;

        public string MyMessage {
            get => _message;
            set => _message = value;
        }
    }
}
