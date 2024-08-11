using Microsoft.AspNetCore.SignalR;

namespace LuckyDices.Web.Hubs;

public class GameHub : Hub
{
    public async Task SendMessageAsync(string user, string message)
        => await Clients.All.SendAsync("ReceiveMessage", user, message);
}
