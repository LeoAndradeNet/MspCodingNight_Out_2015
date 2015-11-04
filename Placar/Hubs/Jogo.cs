using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar.Hubs
{
    public class Jogo : Hub
    {
        public void Gol(int time)
        {
            var connectId = Context.ConnectionId;

            Clients.AllExcept(connectId).AletaGol(time);
        }

        public void Lance(string texto)
        {
            var connectId = Context.ConnectionId;

            Clients.AllExcept(connectId).AletaLance(texto);
        }
    }
}
