using System;
using System.Collections.Generic;
using System.Text;

namespace Akka.Net_Service_Exemple.Messages
{
    public class HeartBeatMessage
    {
        public string Message { get; set; }
        public HeartBeatMessage(string message)
        {
            Message = message;
        }
    }
}
