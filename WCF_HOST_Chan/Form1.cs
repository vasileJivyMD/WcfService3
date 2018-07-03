using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace WCF_HOST_Chan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data_ac = textBox1.Text;
            string msc = string.Empty;

            ChannelFactory<IService1> fact = new ChannelFactory<IService1>("client");
            IService1 channel;
            channel = fact.CreateChannel();
            msc = channel.GetData(data_ac);

            MessageBox.Show(msc);
        }
    }
}
