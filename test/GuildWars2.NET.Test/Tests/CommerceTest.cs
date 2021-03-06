﻿using GuildWars2.NET.v2.Commerce.Entities;
using GuildWars2.NET.v2.Commerce.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class CommerceTest : ApiTest
    {
        private readonly ICommerceRepository repository;

        public CommerceTest()
        {
            repository = Client.Commerce;
        }

        [Fact]
        public void GetDeliveryBox()
        {
            AssertCall<DeliveryBox>(repository.GetDeliveryBox());
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
        [InlineData(100000)]
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
            AssertCall<List<Transaction>>(repository.GetPurchaseHistory());
        }

        [Fact]
        public void GetPurchaseOrders()
        {
            AssertCall<List<Transaction>>(repository.GetPurchaseOrders());
        }

        [Fact]
        public void GetSalesHistory()
        {
            AssertCall<List<Transaction>>(repository.GetSalesHistory());
        }

        [Fact]
        public void GetSalesOrders()
        {
            AssertCall<List<Transaction>>(repository.GetSalesOrders());
        }

        #region Async
        [Fact]
        public async Task GetDeliveryBoxAsync()
        {
            AssertCall<DeliveryBox>(await repository.GetDeliveryBoxAsync());
        }

        [Fact]
        public async Task GetCurrencyTypesAsync()
        {
            AssertCall<List<string>>(await repository.GetCurrencyTypesAsync());
        }

        [Theory]
        [InlineData(100)]
        public async Task GetCoinsAsync(int gems)
        {
            AssertCall<Coins>(await repository.GetCoinsAsync(gems));
        }

        [Theory]
        [InlineData(100000)]
        public async Task GetGemsAsync(int coins)
        {
            AssertCall<Gems>(await repository.GetGemsAsync(coins));
        }

        [Fact]
        public async Task GetListedItemIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetListedItemIdsAsync());
        }

        [Theory]
        [InlineData("24", "68")]
        public async Task GetListedItemsAsync(params string[] ids)
        {
            AssertCall<List<ListedItem>>(await repository.GetListedItemsAsync(ids));
        }

        [Theory]
        [InlineData("69")]
        public async Task GetListedItemAsync(string id)
        {
            AssertCall<ListedItem>(await repository.GetListedItemAsync(id));
        }

        [Fact]
        public async Task GetPricedItemIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetPricedItemIdsAsync());
        }

        [Theory]
        [InlineData("24", "68")]
        public async Task GetPricedItemsAsync(params string[] ids)
        {
            AssertCall<List<PricedItem>>(await repository.GetPricedItemsAsync(ids));
        }

        [Theory]
        [InlineData("69")]
        public async Task GetPricedItemAsync(string id)
        {
            AssertCall<PricedItem>(await repository.GetPricedItemAsync(id));
        }

        [Fact]
        public async Task GetPurchaseHistoryAsync()
        {
            AssertCall<List<Transaction>>(await repository.GetPurchaseHistoryAsync());
        }

        [Fact]
        public async Task GetPurchaseOrdersAsync()
        {
            AssertCall<List<Transaction>>(await repository.GetPurchaseOrdersAsync());
        }

        [Fact]
        public async Task GetSalesHistoryAsync()
        {
            AssertCall<List<Transaction>>(await repository.GetSalesHistoryAsync());
        }

        [Fact]
        public async Task GetSalesOrdersAsync()
        {
            AssertCall<List<Transaction>>(await repository.GetSalesOrdersAsync());
        }
        #endregion
    }
}
