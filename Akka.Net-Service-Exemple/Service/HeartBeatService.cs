using Akka.Actor;
using Akka.Net_Service_Exemple.Actors;
using Akka.Net_Service_Exemple.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using Topshelf;

namespace Akka.Net_Service_Exemple.Service
{
    public class HeartBeatService
    {
        private ActorSystem _actorSystem;
        public void Start()
        {
            _actorSystem = ActorSystem.Create("AkkaServiceExample");

            var heartBeatActor = _actorSystem.ActorOf<HeartBeatActor>();

            _actorSystem.Scheduler.ScheduleTellRepeatedly(TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(10), heartBeatActor, new HeartBeatMessage(DateTime.Now.ToString()), heartBeatActor);
        }

        public void Stop()
        {
            _actorSystem.Terminate();
        }
    }
}
