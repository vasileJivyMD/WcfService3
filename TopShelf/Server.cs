using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Owin.Hosting;

namespace TopShelf
{
    public class Server
    {
        private IDisposable _webapp;
        public void Start()
        {
            _webapp = WebApp.Start("http://localhost:58610");
        }

        public void Stop()
        {
            _webapp?.Dispose();
        }
    }
}

