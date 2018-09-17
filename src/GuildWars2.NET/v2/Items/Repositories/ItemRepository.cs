using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Items.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Items.Repositories
{
    public class ItemRepository : GW2Repository
    {
        public ItemRepository() : base() { }

        public ICollection<string> GetMailCarriers()
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

        public ICollection<string> GetMaterialCategories()
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

        public ICollection<string> GetMiniatures()
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

        public ICollection<string> GetNodes()
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

        public ICollection<string> GetOutfits()
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
        public ICollection<string> GetRecipes()
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

        public ICollection<string> GetSkins()
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
    }
}
