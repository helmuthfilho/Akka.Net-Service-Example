using Akka.Net_Service_Exemple.Service;
using System;
using Topshelf;

namespace Akka.Net_Service_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(host =>
            {
                host.Service<HeartBeatService>(config =>
                {
                    config.ConstructUsing(s => new HeartBeatService());
                    config.WhenStarted(s => s.Start());
                    config.WhenStopped(s => s.Stop());
                });

                host.RunAsLocalSystem();
                host.SetDescription("Sample Akka HeartBeat Service");
                host.SetDisplayName("Sample Akka");
                host.SetServiceName("Sample.Akka");
            });
        }
    }
}
