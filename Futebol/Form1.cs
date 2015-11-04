using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futebol
{
    public partial class Form1 : Form
    {
        public HubConnection hubConnection = new HubConnection("http://localhost:16654/");
        IHubProxy stockTickerHubProxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stockTickerHubProxy = hubConnection.CreateHubProxy("Jogo");
            hubConnection.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GolBrasil
            stockTickerHubProxy.Invoke("Gol", 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GolAlemanha
            stockTickerHubProxy.Invoke("Gol", 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Lance
            stockTickerHubProxy.Invoke("Lance", DateTime.Now.ToLongTimeString() + " - " + textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
