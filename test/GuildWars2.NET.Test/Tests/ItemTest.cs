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
        public void GetCatIds()
        {
            AssertIds<List<string>>(repository.GetCatIds());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public void GetCats(params string[] ids)
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
        public void GetCurrencyIds()
        {
            AssertIds<List<string>>(repository.GetCurrencyIds());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetCurrencies(params string[] ids)
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
        public void GetDyeIds()
        {
            AssertIds<List<string>>(repository.GetDyeIds());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public void GetDyes(params string[] ids)
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
        public void GetFinisherIds()
        {
            AssertIds<List<string>>(repository.GetFinisherIds());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetFinishers(params string[] ids)
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
        public void GetGliderIds()
        {
            AssertIds<List<string>>(repository.GetGliderIds());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public void GetGliders(params string[] ids)
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
        public void GetItemIds()
        {
            AssertIds<List<string>>(repository.GetItemIds());
        }

        [Theory]
        [InlineData("24", "100", "103")]
        public void GetItems(params string[] ids)
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
        public void GetItemStatIds()
        {
            AssertIds<List<string>>(repository.GetItemStatIds());
        }

        [Theory]
        [InlineData("112", "1163", "1227")]
        public void GetItemStats(params string[] ids)
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
        public void GetMailCarrierIds()
        {
            AssertIds<List<string>>(repository.GetMailCarrierIds());
        }

        [Fact]
        public void GetMailCarriers()
        {
            string[] ids = repository.GetMailCarrierIds().ToArray();
            AssertCall<List<MailCarrier>>(repository.GetMailCarriers(ids));
        }

        [Theory]
        [InlineData("6")]
        public void GetMailCarrier(string id)
        {
            AssertCall<MailCarrier>(repository.GetMailCarrier(id));
        }

        [Fact]
        public void GetMaterialCategoryIds()
        {
            AssertIds<List<string>>(repository.GetMaterialCategoryIds());
        }

        [Fact]
        public void GetMaterialCategories()
        {
            string[] ids = repository.GetMaterialCategoryIds().ToArray();
            AssertCall<List<MaterialCategory>>(repository.GetMaterialCategories(ids));
        }

        [Theory]
        [InlineData("6")]
        public void GetMaterialCategory(string id)
        {
            AssertCall<MaterialCategory>(repository.GetMaterialCategory(id));
        }

        [Fact]
        public void GetMiniatureIds()
        {
            AssertIds<List<string>>(repository.GetMiniatureIds());
        }

        [Theory]
        [InlineData("1", "2", "3", "40", "41")]
        public void GetMiniatures(params string[] ids)
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
        public void GetNodeIds()
        {
            AssertIds<List<string>>(repository.GetNodeIds());
        }

        [Fact]
        public void GetNodes()
        {
            string[] ids = repository.GetNodeIds().ToArray();
            AssertCall<List<Node>>(repository.GetNodes(ids));
        }

        [Theory]
        [InlineData("basic_harvesting_nodes")]
        public void GetNode(string id)
        {
            AssertCall<Node>(repository.GetNode(id));
        }

        [Fact]
        public void GetOutfitIds()
        {
            AssertIds<List<string>>(repository.GetOutfitIds());
        }

        [Fact]
        public void GetOutfits()
        {
            string[] ids = repository.GetOutfitIds().ToArray();
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
        public void GetRecipeIds()
        {
            AssertIds<List<string>>(repository.GetRecipeIds());
        }

        [Theory]
        [InlineData("19699")]
        public void GetRecipess(string itemId)
        {
            AssertCall<List<string>>(repository.GetRecipes(itemId, true));
        }

        [Fact]
        public void GetSkinIds()
        {
            AssertIds<List<string>>(repository.GetSkinIds());
        }

        [Theory]
        [InlineData("1", "2", "500", "501", "502")]
        public void GetSkins(params string[] ids)
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
