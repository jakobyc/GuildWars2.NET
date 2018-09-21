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
    }
}
