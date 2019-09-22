using System.Collections.Generic;
using System.Threading.Tasks;
using GuildWars2.NET.v2.Commerce.Entities;

namespace GuildWars2.NET.v2.Commerce.Repositories
{
    public interface ICommerceRepository
    {
        Coins GetCoins(int gems);
        Task<Coins> GetCoinsAsync(int gems);
        ICollection<string> GetCurrencyTypes();
        Task<ICollection<string>> GetCurrencyTypesAsync();
        DeliveryBox GetDeliveryBox();
        Task<DeliveryBox> GetDeliveryBoxAsync();
        Gems GetGems(int coins);
        Task<Gems> GetGemsAsync(int coins);
        ListedItem GetListedItem(string id);
        Task<ListedItem> GetListedItemAsync(string id);
        ICollection<string> GetListedItemIds();
        Task<ICollection<string>> GetListedItemIdsAsync();
        ICollection<ListedItem> GetListedItems(params string[] ids);
        Task<ICollection<ListedItem>> GetListedItemsAsync(params string[] ids);
        PricedItem GetPricedItem(string id);
        Task<PricedItem> GetPricedItemAsync(string id);
        ICollection<string> GetPricedItemIds();
        Task<ICollection<string>> GetPricedItemIdsAsync();
        ICollection<PricedItem> GetPricedItems(params string[] ids);
        Task<ICollection<PricedItem>> GetPricedItemsAsync(params string[] ids);
        ICollection<Transaction> GetPurchaseHistory();
        Task<ICollection<Transaction>> GetPurchaseHistoryAsync();
        ICollection<Transaction> GetPurchaseOrders();
        Task<ICollection<Transaction>> GetPurchaseOrdersAsync();
        ICollection<Transaction> GetSalesHistory();
        Task<ICollection<Transaction>> GetSalesHistoryAsync();
        ICollection<Transaction> GetSalesOrders();
        Task<ICollection<Transaction>> GetSalesOrdersAsync();
    }
}