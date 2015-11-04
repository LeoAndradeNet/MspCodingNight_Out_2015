using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public class Venda : Hub
    {
        public void NovaVenda(int produto)
        {
            var connectId = Context.ConnectionId;
            
            Clients.AllExcept(connectId).AlertarNovaVenda(produto);
        }
    }
}
