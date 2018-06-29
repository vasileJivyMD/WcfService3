using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WcfService3
{
    public class Service1 : IService1
    {
        public string  Message()
        {
            Thread.Sleep(2000);
            return "Hello world , this is my first service !!!";
        }
        public int add(int x, int y )
        {
            
            return x * y;
        }
    }
    
}
