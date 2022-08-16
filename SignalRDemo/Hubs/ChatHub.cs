﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class ChatHub: Hub
    {
        public async Task SendMessage(string fromUser, string message)
        {
            await Clients.All.SendAsync("RecievedMessage", fromUser,message);

        }
    }
}
