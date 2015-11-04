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

namespace Loja
{
    public partial class Form1 : Form
    {
        public HubConnection hubConnection = new HubConnection("http://localhost:10059/");
        IHubProxy stockTickerHubProxy;
               

        public Form1()
        {
            InitializeComponent();            
        }

        public void FinalizarVenda(int produto)
        {   
            stockTickerHubProxy.Invoke("NovaVenda", produto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalizarVenda(1);
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            FinalizarVenda(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinalizarVenda(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FinalizarVenda(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stockTickerHubProxy = hubConnection.CreateHubProxy("Venda");
            hubConnection.Start();
        }
    }
}
