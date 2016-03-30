using Microsoft.AspNet.SignalR;

namespace ChatChat.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void IsOnline(string username)
        {
            Clients.Others.showOnline(username);
        }
    }
}