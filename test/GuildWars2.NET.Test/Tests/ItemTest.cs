using GuildWars2.NET.Core.v2.Items.Entities;
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

        [Theory]
        [InlineData("1", "19699")]
        public void Get(string recipeId, string itemId)
        {
            Assert.NotNull(repository);

            AssertCall<Recipe>(repository.GetRecipe(recipeId));
            AssertCall<int[]>(repository.GetRecipes());
            AssertCall<int[]>(repository.GetRecipes(itemId, true));
        }
    }
}
