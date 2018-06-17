
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace WebAPIHUB
{
    public class ApplicationHub : Hub
    {
        public Task Send(string message){
            return Clients.All.SendAsync("Send",message);
        }

        public Task Broadcast(string message){
            return Clients.Others.SendAsync("Send",message);
        }
    }
}