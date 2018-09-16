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
        public ICollection<int> GetRecipes()
        {
            return Retrieve<ICollection<int>>("recipes");
        }

        /// <summary>
        /// Get the id's of all recipes that either use the provided item id as input or output the provided item id.
        /// </summary>
        /// <param name="itemId">Id of input/output item.</param>
        /// <param name="input">If true, item id is an ingredient. Else, item id is the output.</param>
        public ICollection<int> GetRecipes(string itemId, bool input)
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

            return Retrieve<ICollection<int>>($"recipes/search?{filter}");
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
