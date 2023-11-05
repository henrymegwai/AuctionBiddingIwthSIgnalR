﻿using Microsoft.AspNetCore.SignalR;
using AuctionBidding.Models;

namespace AuctionBidding.Hubs
{
    public class AuctionHub: Hub
    {
        public async Task NotifyNewBid(AuctionNotify auction)
        {
            await Clients.All.SendAsync("ReceiveNewBid", auction);
        }
    }
}
