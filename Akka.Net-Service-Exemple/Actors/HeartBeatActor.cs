using Akka.Actor;
using Akka.Net_Service_Exemple.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Akka.Net_Service_Exemple.Actors
{
    public class HeartBeatActor : ReceiveActor
    {
        public HeartBeatActor()
        {
            Receive<HeartBeatMessage>(m => HeartBeat(m.Message));
        }

        private void HeartBeat(string message)
        {
            using (StreamWriter writer = new StreamWriter(@"D:\Akka.net_TopShelf_Example\service.txt", true))
            {
                writer.WriteLine("The service is still running at " + message);
            }
        }
    }
}
