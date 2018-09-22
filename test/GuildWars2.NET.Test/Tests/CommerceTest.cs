using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Commerce.Entities;
using GuildWars2.NET.v2.Commerce.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class CommerceTest : ApiTest
    {
        private CommerceRepository repository;

        public CommerceTest(RepositoryFactory factory)
        {
            repository = factory.GetCommerceRepository();
        }

        [Fact]
        public void GetDeliveryBox()
        {
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(apiKey))
            {
                AssertCall<DeliveryBox>(repository.GetDeliveryBox(apiKey));
            }
            else
            {
                Assert.True(false, "API key not found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetCurrencyTypes()
        {
            AssertCall<List<string>>(repository.GetCurrencyTypes());
        }

        [Theory]
        [InlineData(100)]
        public void GetCoins(int gems)
        {
            AssertCall<Coins>(repository.GetCoins(gems));
        }

        [Theory]
        [InlineData(10000)]
        public void GetGems(int coins)
        {
            AssertCall<Gems>(repository.GetGems(coins));
        }

        [Fact]
        public void GetListedItemIds()
        {
            AssertIds<List<string>>(repository.GetListedItemIds());
        }

        [Theory]
        [InlineData("24", "68")]
        public void GetListedItems(params string[] ids)
        {
            AssertCall<List<ListedItem>>(repository.GetListedItems(ids));
        }

        [Theory]
        [InlineData("69")]
        public void GetListedItem(string id)
        {
            AssertCall<ListedItem>(repository.GetListedItem(id));
        }

        [Fact]
        public void GetPricedItemIds()
        {
            AssertIds<List<string>>(repository.GetPricedItemIds());
        }

        [Theory]
        [InlineData("24", "68")]
        public void GetPricedItems(params string[] ids)
        {
            AssertCall<List<PricedItem>>(repository.GetPricedItems(ids));
        }

        [Theory]
        [InlineData("69")]
        public void GetPricedItem(string id)
        {
            AssertCall<PricedItem>(repository.GetPricedItem(id));
        }

        [Fact]
        public void GetPurchaseHistory()
        {
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<Transaction>>(repository.GetPurchaseHistory(apiKey));
            }
            else
            {
                Assert.True(false, "API key not found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetPurchaseOrders()
        {
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<Transaction>>(repository.GetPurchaseOrders(apiKey));
            }
            else
            {
                Assert.True(false, "API key not found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetSalesHistory()
        {
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<Transaction>>(repository.GetSalesHistory(apiKey));
            }
            else
            {
                Assert.True(false, "API key not found in appsettings.test.json.");
            }
        }

        [Fact]
        public void GetSalesOrders()
        {
            string apiKey = Config.GetApiKey();
            if (!string.IsNullOrEmpty(apiKey))
            {
                AssertCall<List<Transaction>>(repository.GetSalesOrders(apiKey));
            }
            else
            {
                Assert.True(false, "API key not found in appsettings.test.json.");
            }
        }
    }
}
