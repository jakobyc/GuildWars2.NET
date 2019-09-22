using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Commerce.Repositories
{
    internal class CommerceRepository : GW2Repository, ICommerceRepository
    {
        public CommerceRepository(string apiKey = null) : base(apiKey) { }

        public DeliveryBox GetDeliveryBox()
        {
            ValidateToken();
            return Retrieve<DeliveryBox>($"commerce/delivery");
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
        public ICollection<Transaction> GetPurchaseHistory()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/buys");
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current purchase orders.
        /// </summary>
        public ICollection<Transaction> GetPurchaseOrders()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/buys");
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for historical sales for past 90 days.
        /// </summary>
        public ICollection<Transaction> GetSalesHistory()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/sells");
            return Retrieve<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current sales orders.
        /// </summary>
        public ICollection<Transaction> GetSalesOrders()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/sells");
            return Retrieve<ICollection<Transaction>>(builder);
        }

        #region Async
        public async Task<DeliveryBox> GetDeliveryBoxAsync()
        {
            ValidateToken();
            return await RetrieveAsync<DeliveryBox>($"commerce/delivery");
        }

        public async Task<ICollection<string>> GetCurrencyTypesAsync()
        {
            return await RetrieveAsync<ICollection<string>>("commerce/exchange");
        }

        /// <summary>
        /// Get exchange rate for coins with gems.
        /// </summary>
        public async Task<Coins> GetCoinsAsync(int gems)
        {
            return await RetrieveAsync<Coins>($"commerce/exchange/gems?quantity={gems}");
        }

        /// <summary>
        /// Get exchange rate for gems with coins.
        /// </summary>
        public async Task<Gems> GetGemsAsync(int coins)
        {
            return await RetrieveAsync<Gems>($"commerce/exchange/coins?quantity={coins}");
        }

        public async Task<ICollection<string>> GetListedItemIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("commerce/listings");
        }

        /// <summary>
        /// Get listings for items.
        /// </summary>
        /// <param name="ids">Array of item IDs.</param>
        public async Task<ICollection<ListedItem>> GetListedItemsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/listings")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<ListedItem>>(builder);
        }

        /// <summary>
        /// Get listings for an item.
        /// </summary>
        /// <param name="ids">Item ID.</param>
        public async Task<ListedItem> GetListedItemAsync(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/listings")
                                                            .AddParameter("id", id);
            return await RetrieveAsync<ListedItem>(builder);
        }

        public async Task<ICollection<string>> GetPricedItemIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("commerce/prices");
        }

        /// <summary>
        /// Get pricing information for items.
        /// </summary>
        /// <param name="ids">Item IDs</param>
        public async Task<ICollection<PricedItem>> GetPricedItemsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/prices")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<PricedItem>>(builder);
        }

        /// <summary>
        /// Get pricing information for an item.
        /// </summary>
        /// <param name="id">Item ID</param>
        public async Task<PricedItem> GetPricedItemAsync(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/prices")
                                                            .AddParameter("id", id);
            return await RetrieveAsync<PricedItem>(builder);
        }

        /// <summary>
        /// Get transactions for historical purchases for past 90 days.
        /// </summary>
        public async Task<ICollection<Transaction>> GetPurchaseHistoryAsync()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/buys");
            return await RetrieveAsync<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current purchase orders.
        /// </summary>
        public async Task<ICollection<Transaction>> GetPurchaseOrdersAsync()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/buys");
            return await RetrieveAsync<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for historical sales for past 90 days.
        /// </summary>
        public async Task<ICollection<Transaction>> GetSalesHistoryAsync()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/history/sells");
            return await RetrieveAsync<ICollection<Transaction>>(builder);
        }

        /// <summary>
        /// Get transactions for current sales orders.
        /// </summary>
        public async Task<ICollection<Transaction>> GetSalesOrdersAsync()
        {
            ValidateToken();

            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("commerce/transactions/current/sells");
            return await RetrieveAsync<ICollection<Transaction>>(builder);
        }
        #endregion
    }
}
