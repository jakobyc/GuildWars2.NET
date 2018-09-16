using GuildWars2.NET.v2.Items.Entities;
using GuildWars2.NET.v2.Items.Repositories;
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
        [InlineData("1")]
        public void GetRecipe(string recipeId)
        {
            AssertCall<Recipe>(repository.GetRecipe(recipeId));
        }

        [Fact]
        public void GetRecipes()
        {
            AssertCall<List<int>>(repository.GetRecipes());
        }

        [Theory]
        [InlineData("19699")]
        public void GetRecipesByIds(string itemId)
        {
            AssertCall<List<int>>(repository.GetRecipes(itemId, true));
        }
    }
}
