using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;
using Microsoft.Owin.Hosting;

namespace TopShelf
{
    class Program
    {
        static void Main(string[] args)
        {

            HostFactory.Run(x =>
                   {
                       x.Service<Server>(s =>
                       {
                           s.ConstructUsing(name => new Server());
                           s.WhenStarted(tc => tc.Start());
                           s.WhenStopped(tc => tc.Stop());

                       });
                       x.RunAsLocalSystem();
                       x.SetDescription("demoservice");
                       x.SetDisplayName("demo");
                       x.SetServiceName("demo");
                   });
    }
    }
}

