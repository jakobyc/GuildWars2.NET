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

        public ICollection<string> GetCurrencyTypes()
        {
            return Retrieve<ICollection<string>>("commerce/exchange");
        }

        /// <summary>
        /// Get exchange rate for coins with gems.
        /// </summary>
        public Coins GetCoins(int gems)
        {
            return Retrieve<Coins>($"commerce/exchange/gems?quantity={gems}");
        }

        /// <summary>
        /// Get exchange rate for gems with coins.
        /// </summary>
        public Gems GetGems(int coins)
        {
            return Retrieve<Gems>($"commerce/exchange/coins?quantity={coins}");
        }
    }
}
