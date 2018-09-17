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
        public void GetMailCarriers()
        {
            AssertCall<List<string>>(repository.GetMailCarriers());
        }

        [Fact]
        public void GetMailCarriersById()
        {
            string[] ids = repository.GetMailCarriers().ToArray();
            AssertCall<List<MailCarrier>>(repository.GetMailCarriers(ids));
        }

        [Theory]
        [InlineData("6")]
        public void GetMailCarrier(string id)
        {
            AssertCall<MailCarrier>(repository.GetMailCarrier(id));
        }

        [Fact]
        public void GetMaterialCategories()
        {
            AssertCall<List<string>>(repository.GetMaterialCategories());
        }

        [Fact]
        public void GetMaterialCategoriesById()
        {
            string[] ids = repository.GetMaterialCategories().ToArray();
            AssertCall<List<MaterialCategory>>(repository.GetMaterialCategories(ids));
        }

        [Theory]
        [InlineData("6")]
        public void GetMaterialCategory(string id)
        {
            AssertCall<MaterialCategory>(repository.GetMaterialCategory(id));
        }

        [Fact]
        public void GetMiniatures()
        {
            AssertCall<List<string>>(repository.GetMiniatures());
        }

        [Theory]
        [InlineData("1", "2", "3", "40", "41")]
        public void GetMiniaturesById(params string[] ids)
        {
            AssertCall<List<Miniature>>(repository.GetMiniatures(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetMiniature(string id)
        {
            AssertCall<Miniature>(repository.GetMiniature(id));
        }

        [Fact]
        public void GetNodes()
        {
            AssertCall<List<string>>(repository.GetNodes());
        }

        [Fact]
        public void GetNodesById()
        {
            string[] ids = repository.GetNodes().ToArray();
            AssertCall<List<Node>>(repository.GetNodes(ids));
        }

        [Theory]
        [InlineData("basic_harvesting_nodes")]
        public void GetNode(string id)
        {
            AssertCall<Node>(repository.GetNode(id));
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
