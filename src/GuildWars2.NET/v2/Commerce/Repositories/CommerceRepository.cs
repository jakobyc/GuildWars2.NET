using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Commerce.Repositories
{
    public class CommerceRepository : GW2Repository
    {
        public CommerceRepository() : base() { }

        public DeliveryBox GetDeliveryBox(string apiKey)
        {
            return Retrieve<DeliveryBox>($"commerce/delivery?access_token={apiKey}");
        }
    }
}
