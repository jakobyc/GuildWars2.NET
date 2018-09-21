using GuildWars2.NET.Builders.Endpoints;
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

        public ICollection<string> GetListedItemIds()
        {
            return Retrieve<ICollection<string>>("commerce/listings");
        }

        /// <summary>
        /// Get listings for items.
        /// </summary>
        /// <param name="ids">Array of item IDs.</param>
        public ICollection<ListedItem> GetListedItems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/listings")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<ListedItem>>(builder);
        }

        /// <summary>
        /// Get listings for an item.
        /// </summary>
        /// <param name="ids">Item ID.</param>
        public ListedItem GetListedItem(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/listings")
                                                            .AddParameter("id", id);
            return Retrieve<ListedItem>(builder);
        }

        public ICollection<string> GetPricedItemIds()
        {
            return Retrieve<ICollection<string>>("commerce/prices");
        }

        /// <summary>
        /// Get pricing information for items.
        /// </summary>
        /// <param name="ids">Item IDs</param>
        public ICollection<PricedItem> GetPricedItems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/prices")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<PricedItem>>(builder);
        }

        /// <summary>
        /// Get pricing information for an item.
        /// </summary>
        /// <param name="id">Item ID</param>
        public PricedItem GetPricedItem(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/prices")
                                                            .AddParameter("id", id);
            return Retrieve<PricedItem>(builder);
        }

        /// <summary>
        /// Get transactions for historical purchases for past 90 days.
        /// </summary>
        public ICollection<Transaction> GetPurchaseHistory(string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/buys")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current purchase orders.
        /// </summary>
        public ICollection<Transaction> GetPurchaseOrders(string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/buys")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for historical sales for past 90 days.
        /// </summary>
        public ICollection<Transaction> GetSalesHistory(string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/sells")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current sales orders.
        /// </summary>
        public ICollection<Transaction> GetSalesOrders(string apiKey)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/sells")
                                                            .AddParameter("access_token", apiKey);
            return Retrieve<ICollection<Transaction>>(builder);
        }
    }
}
