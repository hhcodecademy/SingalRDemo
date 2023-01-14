using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingalRDemo.API.HubDomain
{
    public class PHub : Hub
    {
        public async Task sendMessage(string message)
        {
          

            await Clients.All.SendAsync("RecieveMessage", message);

        }
    }
}
