using GuildWars2.NET.Core.v2.Items.DTOs;
using GuildWars2.NET.Core.v2.Items.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class ItemTest : ApiTest
    {
        private ItemRepository repository;

        public ItemTest(RepositoryFactory factory)
        {
            this.repository = factory.GetItemRepository();
        }

        [Fact]
        public void Get()
        {
            Assert.NotNull(repository);

            AssertCall<Recipe>(repository.GetRecipe("1"));
            AssertCall<int[]>(repository.GetRecipes());
            AssertCall<int[]>(repository.GetRecipes("19699", true));
        }
    }
}
