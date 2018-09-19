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
        public void GetAllCats()
        {
            AssertCall<List<Cat>>(repository.GetAllCats());
        }

        [Fact]
        public void GetCats()
        {
            AssertCall<List<string>>(repository.GetCats());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public void GetCatsById(params string[] ids)
        {
            AssertCall<List<Cat>>(repository.GetCats(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetCat(string id)
        {
            AssertCall<Cat>(repository.GetCat(id));
        }

        [Fact]
        public void GetAllCurrencies()
        {
            AssertCall<List<Currency>>(repository.GetAllCurrencies());
        }

        [Fact]
        public void GetCurrencies()
        {
            AssertCall<List<string>>(repository.GetCurrencies());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetCurrenciesById(params string[] ids)
        {
            AssertCall<List<Currency>>(repository.GetCurrencies(ids));
        }

        [Theory]
        [InlineData("44")]
        public void GetCurrency(string id)
        {
            AssertCall<Currency>(repository.GetCurrency(id));
        }

        [Fact]
        public void GetAllDyes()
        {
            AssertCall<List<Dye>>(repository.GetAllDyes());
        }

        [Fact]
        public void GetDyes()
        {
            AssertCall<List<string>>(repository.GetDyes());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public void GetDyesById(params string[] ids)
        {
            AssertCall<List<Dye>>(repository.GetDyes(ids));
        }

        [Theory]
        [InlineData("1")]
        public void GetDye(string id)
        {
            AssertCall<Dye>(repository.GetDye(id));
        }

        [Fact]
        public void GetFinishers()
        {
            AssertCall<List<string>>(repository.GetFinishers());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetFinishersById(params string[] ids)
        {
            AssertCall<List<Finisher>>(repository.GetFinishers(ids));
        }

        [Theory]
        [InlineData("46")]
        public void GetFinisher(string id)
        {
            AssertCall<Finisher>(repository.GetFinisher(id));
        }

        [Fact]
        public void GetGliders()
        {
            AssertCall<List<string>>(repository.GetGliders());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetGlidersById(params string[] ids)
        {
            AssertCall<List<Glider>>(repository.GetGliders(ids));
        }

        [Theory]
        [InlineData("46")]
        public void GetGlider(string id)
        {
            AssertCall<Glider>(repository.GetGlider(id));
        }

        [Fact]
        public void GetItems()
        {
            AssertCall<List<string>>(repository.GetItems());
        }

        [Theory]
        [InlineData("24", "100", "103")]
        public void GetItemsById(params string[] ids)
        {
            AssertCall<List<Item>>(repository.GetItems(ids));
        }

        [Theory]
        [InlineData("46")]
        public void GetItem(string id)
        {
            AssertCall<Item>(repository.GetItem(id));
        }

        [Fact]
        public void GetItemStats()
        {
            AssertCall<List<string>>(repository.GetItemStats());
        }

        [Theory]
        [InlineData("112", "1163", "1227")]
        public void GetItemStatsById(params string[] ids)
        {
            AssertCall<List<ItemStat>>(repository.GetItemStats(ids));
        }

        [Theory]
        [InlineData("1222")]
        public void GetItemStat(string id)
        {
            AssertCall<ItemStat>(repository.GetItemStat(id));
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
