using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF_HOST
{
    class StartService
    {
        ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
        public void Start()
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceLibrary1.Service1));
            host.Open();
            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();
        }
        public void Stop() { host.Abort(); }

    }
}
