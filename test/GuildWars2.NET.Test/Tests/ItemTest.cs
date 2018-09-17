using GuildWars2.NET.v2.Items.Entities;
using GuildWars2.NET.v2.Items.Repositories;
using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

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
        public void GetOutfits()
        {
            AssertCall<List<string>>(repository.GetOutfits());
        }

        [Fact]
        public void GetOutfitsById()
        {
            string[] ids = repository.GetOutfits().ToArray();
            AssertCall<List<Outfit>>(repository.GetOutfits(ids));
        }

        [Theory]
        [InlineData("10")]
        public void GetOutfit(string id)
        {
            AssertCall<Outfit>(repository.GetOutfit(id));
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
            AssertCall<List<string>>(repository.GetRecipes());
        }

        [Theory]
        [InlineData("19699")]
        public void GetRecipesByIds(string itemId)
        {
            AssertCall<List<string>>(repository.GetRecipes(itemId, true));
        }

        [Fact]
        public void GetSkins()
        {
            AssertCall<List<string>>(repository.GetSkins());
        }

        [Theory]
        [InlineData("1", "2", "500", "501", "502")]
        public void GetSkinsById(params string[] ids)
        {
            AssertCall<List<Skin>>(repository.GetSkins(ids));
        }

        [Theory]
        [InlineData("10")]
        public void GetSkin(string id)
        {
            AssertCall<Skin>(repository.GetSkin(id));
        }
    }
}
