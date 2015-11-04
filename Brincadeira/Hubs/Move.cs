using Brincadeira.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brincadeira.Hubs
{
    public class MoveShapeHub : Hub
    {
        public void UpdateModel(ShapeModel clientModel)
        {
            clientModel.LastUpdatedBy = Context.ConnectionId;

            Clients.AllExcept(clientModel.LastUpdatedBy).updateShape(clientModel);
        }


    }
}
