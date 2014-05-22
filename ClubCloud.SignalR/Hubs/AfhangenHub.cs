using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.SignalR.Hubs
{
    [HubName("Afhangen")]
    public class AfhangenHub : Hub
    {
        public override Task OnConnected()
        {
            string name = Context.User.Identity.Name.ToUpper();

            Groups.Add(Context.ConnectionId, name);

            return base.OnConnected();
        }
    }
}
