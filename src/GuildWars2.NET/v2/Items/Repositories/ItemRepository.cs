using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Items.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Items.Repositories
{
    internal class ItemRepository : GW2Repository, IItemRepository
    {
        public ItemRepository() : base() { }

        public ICollection<Cat> GetAllCats()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("cats")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<Cat>>(builder);
        }

        public ICollection<string> GetCatIds()
        {
            return Retrieve<ICollection<string>>("cats");
        }

        public ICollection<Cat> GetCats(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("cats")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Cat>>(builder);
        }

        public Cat GetCat(string id)
        {
            return Retrieve<Cat>($"cats/{id}");
        }

        public ICollection<Currency> GetAllCurrencies()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("currencies")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<Currency>>(builder);
        }

        public ICollection<string> GetCurrencyIds()
        {
            return Retrieve<ICollection<string>>("currencies");
        }

        public ICollection<Currency> GetCurrencies(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("currencies")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Currency>>(builder);
        }

        public Currency GetCurrency(string id)
        {
            return Retrieve<Currency>($"currencies/{id}");
        }

        public ICollection<Dye> GetAllDyes()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("colors")
                                                            .AddParameter("ids", "all");
            return Retrieve<ICollection<Dye>>(builder);
        }

        public ICollection<string> GetDyeIds()
        {
            return Retrieve<ICollection<string>>("colors");
        }

        public ICollection<Dye> GetDyes(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("colors")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Dye>>(builder);
        }

        public Dye GetDye(string id)
        {
            return Retrieve<Dye>($"colors/{id}");
        }

        public ICollection<string> GetFinisherIds()
        {
            return Retrieve<ICollection<string>>("finishers");
        }

        public ICollection<Finisher> GetFinishers(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("finishers")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Finisher>>(builder);
        }

        public Finisher GetFinisher(string id)
        {
            return Retrieve<Finisher>($"finishers/{id}");
        }

        public ICollection<string> GetGliderIds()
        {
            return Retrieve<ICollection<string>>("gliders");
        }

        public ICollection<Glider> GetGliders(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("gliders")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Glider>>(builder);
        }

        public Glider GetGlider(string id)
        {
            return Retrieve<Glider>($"gliders/{id}");
        }

        public ICollection<string> GetItemIds()
        {
            return Retrieve<ICollection<string>>("items");
        }

        public ICollection<Item> GetItems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("items")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Item>>(builder);
        }

        public Item GetItem(string id)
        {
            return Retrieve<Item>($"items/{id}");
        }

        public ICollection<string> GetItemStatIds()
        {
            return Retrieve<ICollection<string>>("itemstats");
        }

        public ICollection<ItemStat> GetItemStats(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("itemstats")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<ItemStat>>(builder);
        }

        public ItemStat GetItemStat(string id)
        {
            return Retrieve<ItemStat>($"itemstats/{id}");
        }

        public ICollection<string> GetMailCarrierIds()
        {
            return Retrieve<ICollection<string>>("mailcarriers");
        }

        public ICollection<MailCarrier> GetMailCarriers(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("mailcarriers")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<MailCarrier>>(builder);
        }

        public MailCarrier GetMailCarrier(string id)
        {
            return Retrieve<MailCarrier>($"mailcarriers/{id}");
        }

        public ICollection<string> GetMaterialCategoryIds()
        {
            return Retrieve<ICollection<string>>("materials");
        }

        public ICollection<MaterialCategory> GetMaterialCategories(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("materials")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<MaterialCategory>>(builder);
        }

        public MaterialCategory GetMaterialCategory(string id)
        {
            return Retrieve<MaterialCategory>($"materials/{id}");
        }

        public ICollection<string> GetMiniatureIds()
        {
            return Retrieve<ICollection<string>>("minis");
        }

        public ICollection<Miniature> GetMiniatures(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("minis")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Miniature>>(builder);
        }

        public Miniature GetMiniature(string id)
        {
            return Retrieve<Miniature>($"minis/{id}");
        }

        public ICollection<string> GetNodeIds()
        {
            return Retrieve<ICollection<string>>("nodes");
        }

        public ICollection<Node> GetNodes(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("nodes")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Node>>(builder);
        }

        public Node GetNode(string id)
        {
            return Retrieve<Node>($"nodes/{id}");
        }

        public ICollection<string> GetOutfitIds()
        {
            return Retrieve<ICollection<string>>("outfits");
        }

        public ICollection<Outfit> GetOutfits(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("outfits")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Outfit>>(builder);
        }

        public Outfit GetOutfit(string id)
        {
            return Retrieve<Outfit>($"outfits/{id}");
        }

        /// <summary>
        /// Get a specific recipe by id.
        /// </summary>
        public Recipe GetRecipe(string id)
        {
            return Retrieve<Recipe>($"recipes/{id}");
        }

        /// <summary>
        /// Get the id's of all recipes.
        /// </summary>
        public ICollection<string> GetRecipeIds()
        {
            return Retrieve<ICollection<string>>("recipes");
        }

        /// <summary>
        /// Get the id's of all recipes that either use the provided item id as input or output the provided item id.
        /// </summary>
        /// <param name="itemId">Id of input/output item.</param>
        /// <param name="input">If true, item id is an ingredient. Else, item id is the output.</param>
        public ICollection<string> GetRecipes(string itemId, bool input)
        {
            string filter = string.Empty;
            if (input)
            {
                filter = $"input={itemId}";
            }
            else
            {
                filter = $"output={itemId}";
            }

            return Retrieve<ICollection<string>>($"recipes/search?{filter}");
        }

        public ICollection<string> GetSkinIds()
        {
            return Retrieve<ICollection<string>>("skins");
        }

        public ICollection<Skin> GetSkins(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skins")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Skin>>(builder);
        }

        public Skin GetSkin(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skins")
                                                            .AddParameter("id", id);
            return Retrieve<Skin>(builder);
        }

        #region Async
        public async Task<ICollection<Cat>> GetAllCatsAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("cats")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<Cat>>(builder);
        }

        public async Task<ICollection<string>> GetCatIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("cats");
        }

        public async Task<ICollection<Cat>> GetCatsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("cats")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Cat>>(builder);
        }

        public async Task<Cat> GetCatAsync(string id)
        {
            return await RetrieveAsync<Cat>($"cats/{id}");
        }

        public async Task<ICollection<Currency>> GetAllCurrenciesAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("currencies")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<Currency>>(builder);
        }

        public async Task<ICollection<string>> GetCurrencyIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("currencies");
        }

        public async Task<ICollection<Currency>> GetCurrenciesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("currencies")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Currency>>(builder);
        }

        public async Task<Currency> GetCurrencyAsync(string id)
        {
            return await RetrieveAsync<Currency>($"currencies/{id}");
        }

        public async Task<ICollection<Dye>> GetAllDyesAsync()
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("colors")
                                                            .AddParameter("ids", "all");
            return await RetrieveAsync<ICollection<Dye>>(builder);
        }

        public async Task<ICollection<string>> GetDyeIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("colors");
        }

        public async Task<ICollection<Dye>> GetDyesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("colors")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Dye>>(builder);
        }

        public async Task<Dye> GetDyeAsync(string id)
        {
            return await RetrieveAsync<Dye>($"colors/{id}");
        }

        public async Task<ICollection<string>> GetFinisherIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("finishers");
        }

        public async Task<ICollection<Finisher>> GetFinishersAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("finishers")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Finisher>>(builder);
        }

        public async Task<Finisher> GetFinisherAsync(string id)
        {
            return await RetrieveAsync<Finisher>($"finishers/{id}");
        }

        public async Task<ICollection<string>> GetGliderIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("gliders");
        }

        public async Task<ICollection<Glider>> GetGlidersAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("gliders")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Glider>>(builder);
        }

        public async Task<Glider> GetGliderAsync(string id)
        {
            return await RetrieveAsync<Glider>($"gliders/{id}");
        }

        public async Task<ICollection<string>> GetItemIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("items");
        }

        public async Task<ICollection<Item>> GetItemsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("items")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Item>>(builder);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await RetrieveAsync<Item>($"items/{id}");
        }

        public async Task<ICollection<string>> GetItemStatIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("itemstats");
        }

        public async Task<ICollection<ItemStat>> GetItemStatsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("itemstats")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<ItemStat>>(builder);
        }

        public async Task<ItemStat> GetItemStatAsync(string id)
        {
            return await RetrieveAsync<ItemStat>($"itemstats/{id}");
        }

        public async Task<ICollection<string>> GetMailCarrierIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("mailcarriers");
        }

        public async Task<ICollection<MailCarrier>> GetMailCarriersAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("mailcarriers")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<MailCarrier>>(builder);
        }

        public async Task<MailCarrier> GetMailCarrierAsync(string id)
        {
            return await RetrieveAsync<MailCarrier>($"mailcarriers/{id}");
        }

        public async Task<ICollection<string>> GetMaterialCategoryIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("materials");
        }

        public async Task<ICollection<MaterialCategory>> GetMaterialCategoriesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("materials")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<MaterialCategory>>(builder);
        }

        public async Task<MaterialCategory> GetMaterialCategoryAsync(string id)
        {
            return await RetrieveAsync<MaterialCategory>($"materials/{id}");
        }

        public async Task<ICollection<string>> GetMiniatureIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("minis");
        }

        public async Task<ICollection<Miniature>> GetMiniaturesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("minis")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Miniature>>(builder);
        }

        public async Task<Miniature> GetMiniatureAsync(string id)
        {
            return await RetrieveAsync<Miniature>($"minis/{id}");
        }

        public async Task<ICollection<string>> GetNodeIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("nodes");
        }

        public async Task<ICollection<Node>> GetNodesAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("nodes")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Node>>(builder);
        }

        public async Task<Node> GetNodeAsync(string id)
        {
            return await RetrieveAsync<Node>($"nodes/{id}");
        }

        public async Task<ICollection<string>> GetOutfitIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("outfits");
        }

        public async Task<ICollection<Outfit>> GetOutfitsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("outfits")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Outfit>>(builder);
        }

        public async Task<Outfit> GetOutfitAsync(string id)
        {
            return await RetrieveAsync<Outfit>($"outfits/{id}");
        }

        /// <summary>
        /// Get a specific recipe by id.
        /// </summary>
        public async Task<Recipe> GetRecipeAsync(string id)
        {
            return await RetrieveAsync<Recipe>($"recipes/{id}");
        }

        /// <summary>
        /// Get the id's of all recipes.
        /// </summary>
        public async Task<ICollection<string>> GetRecipeIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("recipes");
        }

        /// <summary>
        /// Get the id's of all recipes that either use the provided item id as input or output the provided item id.
        /// </summary>
        /// <param name="itemId">Id of input/output item.</param>
        /// <param name="input">If true, item id is an ingredient. Else, item id is the output.</param>
        public async Task<ICollection<string>> GetRecipesAsync(string itemId, bool input)
        {
            string filter = string.Empty;
            if (input)
            {
                filter = $"input={itemId}";
            }
            else
            {
                filter = $"output={itemId}";
            }

            return await RetrieveAsync<ICollection<string>>($"recipes/search?{filter}");
        }

        public async Task<ICollection<string>> GetSkinIdsAsync()
        {
            return await RetrieveAsync<ICollection<string>>("skins");
        }

        public async Task<ICollection<Skin>> GetSkinsAsync(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skins")
                                                            .AddParameter("ids", ids);
            return await RetrieveAsync<ICollection<Skin>>(builder);
        }

        public async Task<Skin> GetSkinAsync(string id)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("skins")
                                                            .AddParameter("id", id);
            return await RetrieveAsync<Skin>(builder);
        }
        #endregion
    }
}
