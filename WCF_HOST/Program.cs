using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace WCF_HOST
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>                                   
            {
                x.Service<StartService>(s =>                                   
                {
                    s.ConstructUsing(name => new StartService());                
                    s.WhenStarted(tc => tc.Start());                         
                    s.WhenStopped(tc => tc.Stop());                          
                });
                x.RunAsLocalService();                                       

                x.SetDescription("Sample Topshelf Host");                   
                x.SetDisplayName("Stuff");                                  
                x.SetServiceName("Stuff");                                  
            });                                                             

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());  
            Environment.ExitCode = exitCode;
        }
    }
    }

