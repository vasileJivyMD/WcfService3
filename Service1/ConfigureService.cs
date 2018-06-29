using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Service1
{
    internal static class ConfigureService
    {
        internal static void Configure()
        {
            HostFactory.Run(configure =>
            {
                configure.Service<MyService>(service =>
                {
                    service.ConstructUsing(s => new MyService());
                    service.WhenStarted(s => s.Start());
                    service.WhenStopped(s => s.Stop());

                });
                configure.RunAsLocalSystem();
                configure.SetServiceName("My first service");
                configure.SetDisplayName("My first service");
                configure.SetDescription("Service in topshelf");
            });
        }
    }
}
