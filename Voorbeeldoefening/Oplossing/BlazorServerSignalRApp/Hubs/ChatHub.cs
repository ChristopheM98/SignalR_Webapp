using Microsoft.AspNetCore.SignalR;

namespace BlazorServerSignalRApp.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string user, string message) 
        {
            return Clients.All.SendAsync(method: "ReceiveMessage", user, message);

        }

        //Dit is de "server"
        //Als iemand de SendMessage methode oproept geven we een gebruiker en bericht mee
        //Alle clienten krijgen dit bericht door de methode ReceiveMessage met gebruiker en bericht
    }
}
