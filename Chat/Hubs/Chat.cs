using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Hubs
{
    public class Chat : Hub
    {
        public void SendMessage(string name, string message)
        {
            Clients.All.PublishMessage(name, message);
        }
    }
}
