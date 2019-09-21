using GuildWars2.NET.v2.Items.Entities;
using GuildWars2.NET.v2.Items.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using System.Threading.Tasks;

namespace GuildWars2.NET.Test.Tests
{
    public class ItemTest : ApiTest
    {
        private readonly ItemRepository repository;

        public ItemTest()
        {
            this.repository = Client.Items;
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

        #region Async
        [Fact]
        public async Task GetAllCatsAsyncAsync()
        {
            AssertCall<List<Cat>>(await repository.GetAllCatsAsync());
        }

        [Fact]
        public async Task GetCatIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetCatIdsAsync());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public async Task GetCatsAsync(params string[] ids)
        {
            AssertCall<List<Cat>>(await repository.GetCatsAsync(ids));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetCatAsync(string id)
        {
            AssertCall<Cat>(await repository.GetCatAsync(id));
        }

        [Fact]
        public async Task GetAllCurrenciesAsync()
        {
            AssertCall<List<Currency>>(await repository.GetAllCurrenciesAsync());
        }

        [Fact]
        public async Task GetCurrencyIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetCurrencyIdsAsync());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public async Task GetCurrenciesAsync(params string[] ids)
        {
            AssertCall<List<Currency>>(await repository.GetCurrenciesAsync(ids));
        }

        [Theory]
        [InlineData("44")]
        public async Task GetCurrencyAsync(string id)
        {
            AssertCall<Currency>(await repository.GetCurrencyAsync(id));
        }

        [Fact]
        public async Task GetAllDyesAsync()
        {
            AssertCall<List<Dye>>(await repository.GetAllDyesAsync());
        }

        [Fact]
        public async Task GetDyeIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetDyeIdsAsync());
        }

        [Theory]
        [InlineData("2", "3", "4")]
        public async Task GetDyesAsync(params string[] ids)
        {
            AssertCall<List<Dye>>(await repository.GetDyesAsync(ids));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetDyeAsync(string id)
        {
            AssertCall<Dye>(await repository.GetDyeAsync(id));
        }

        [Fact]
        public async Task GetFinisherIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetFinisherIdsAsync());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public async Task GetFinishersAsync(params string[] ids)
        {
            AssertCall<List<Finisher>>(await repository.GetFinishersAsync(ids));
        }

        [Theory]
        [InlineData("46")]
        public async Task GetFinisherAsync(string id)
        {
            AssertCall<Finisher>(await repository.GetFinisherAsync(id));
        }

        [Fact]
        public async Task GetGliderIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetGliderIdsAsync());
        }

        [Theory]
        [InlineData("1", "3", "5")]
        public async Task GetGlidersAsync(params string[] ids)
        {
            AssertCall<List<Glider>>(await repository.GetGlidersAsync(ids));
        }

        [Theory]
        [InlineData("46")]
        public async Task GetGliderAsync(string id)
        {
            AssertCall<Glider>(await repository.GetGliderAsync(id));
        }

        [Fact]
        public async Task GetItemIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetItemIdsAsync());
        }

        [Theory]
        [InlineData("24", "100", "103")]
        public async Task GetItemsAsync(params string[] ids)
        {
            AssertCall<List<Item>>(await repository.GetItemsAsync(ids));
        }

        [Theory]
        [InlineData("46")]
        public async Task GetItemAsync(string id)
        {
            AssertCall<Item>(await repository.GetItemAsync(id));
        }

        [Fact]
        public async Task GetItemStatIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetItemStatIdsAsync());
        }

        [Theory]
        [InlineData("112", "1163", "1227")]
        public async Task GetItemStatsAsync(params string[] ids)
        {
            AssertCall<List<ItemStat>>(await repository.GetItemStatsAsync(ids));
        }

        [Theory]
        [InlineData("1222")]
        public async Task GetItemStatAsync(string id)
        {
            AssertCall<ItemStat>(await repository.GetItemStatAsync(id));
        }

        [Fact]
        public async Task GetMailCarrierIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMailCarrierIdsAsync());
        }

        [Fact]
        public async Task GetMailCarriersAsync()
        {
            ICollection<string> ids = await repository.GetMailCarrierIdsAsync();
            AssertCall<List<MailCarrier>>(await repository.GetMailCarriersAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("6")]
        public async Task GetMailCarrierAsync(string id)
        {
            AssertCall<MailCarrier>(await repository.GetMailCarrierAsync(id));
        }

        [Fact]
        public async Task GetMaterialCategoryIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMaterialCategoryIdsAsync());
        }

        [Fact]
        public async Task GetMaterialCategoriesAsync()
        {
            ICollection<string> ids = await repository.GetMaterialCategoryIdsAsync();
            AssertCall<List<MaterialCategory>>(await repository.GetMaterialCategoriesAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("6")]
        public async Task GetMaterialCategoryAsync(string id)
        {
            AssertCall<MaterialCategory>(await repository.GetMaterialCategoryAsync(id));
        }

        [Fact]
        public async Task GetMiniatureIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetMiniatureIdsAsync());
        }

        [Theory]
        [InlineData("1", "2", "3", "40", "41")]
        public async Task GetMiniaturesAsync(params string[] ids)
        {
            AssertCall<List<Miniature>>(await repository.GetMiniaturesAsync(ids));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetMiniatureAsync(string id)
        {
            AssertCall<Miniature>(await repository.GetMiniatureAsync(id));
        }

        [Fact]
        public async Task GetNodeIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetNodeIdsAsync());
        }

        [Fact]
        public async Task GetNodesAsync()
        {
            ICollection<string> ids = await repository.GetNodeIdsAsync();
            AssertCall<List<Node>>(await repository.GetNodesAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("basic_harvesting_nodes")]
        public async Task GetNodeAsync(string id)
        {
            AssertCall<Node>(await repository.GetNodeAsync(id));
        }

        [Fact]
        public async Task GetOutfitIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetOutfitIdsAsync());
        }

        [Fact]
        public async Task GetOutfitsAsync()
        {
            ICollection<string> ids = await repository.GetOutfitIdsAsync();
            AssertCall<List<Outfit>>(await repository.GetOutfitsAsync(ids.ToArray()));
        }

        [Theory]
        [InlineData("10")]
        public async Task GetOutfitAsync(string id)
        {
            AssertCall<Outfit>(await repository.GetOutfitAsync(id));
        }

        [Theory]
        [InlineData("1")]
        public async Task GetRecipeAsync(string recipeId)
        {
            AssertCall<Recipe>(await repository.GetRecipeAsync(recipeId));
        }

        [Fact]
        public async Task GetRecipeIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetRecipeIdsAsync());
        }

        [Theory]
        [InlineData("19699")]
        public async Task GetRecipessAsync(string itemId)
        {
            AssertCall<List<string>>(await repository.GetRecipesAsync(itemId, true));
        }

        [Fact]
        public async Task GetSkinIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetSkinIdsAsync());
        }

        [Theory]
        [InlineData("1", "2", "500", "501", "502")]
        public async Task GetSkinsAsync(params string[] ids)
        {
            AssertCall<List<Skin>>(await repository.GetSkinsAsync(ids));
        }

        [Theory]
        [InlineData("10")]
        public async Task GetSkinAsync(string id)
        {
            AssertCall<Skin>(await repository.GetSkinAsync(id));
        }
        #endregion
    }
}
