using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace ChatApp_WF
{
    public partial class Form1 : Form
    {
        IHubProxy proxy;
        public Form1()
        {
            InitializeComponent();

            HubConnection con = new HubConnection("http://localhost:8011/");
            proxy = con.CreateHubProxy("chat");
            con.Start();
            //Deserilization according to proxy invoke data type
            proxy.On<string, string>("newMessage", (n, m) => lb_msg.Invoke(new Action(()=>lb_msg.Items.Add(n +" :: "+ m))));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            proxy.Invoke("sendMessage", txt_name.Text, txt_msg.Text);
        }
    }
}
