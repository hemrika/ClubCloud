using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.SignalR.Hubs
{
    [HubName("Mijn")]
    public class MijnHub : Hub
    {
        public Task JoinClub(string id)
        {
            return Groups.Add(Context.ConnectionId, id);
        }


        public Task LeaveClub(string id)
        {
            return Groups.Remove(Context.ConnectionId, id);
        }

    }
}
