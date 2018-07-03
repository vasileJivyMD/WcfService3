using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfService3;

namespace WindowsService
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost s = null;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if(s!= null)
            {
                s.Close();
            }
            Uri httpUrl = new Uri("http://localhost:58610/Service1.svc");
            s = new ServiceHost(typeof(WcfService3.Service1), httpUrl);
            s.AddServiceEndpoint(typeof(WcfService3.IService1), new WSHttpBinding(), "");
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpsGetEnabled = true;
            s.Description.Behaviors.Add(smb);
            s.Open();

        }

        protected override void OnStop()
        {
            if(s!=null)
            {
                s.Close();
                s = null;
            }
        }
    }
}
