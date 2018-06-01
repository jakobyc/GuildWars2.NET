using GuildWars2.NET.Core.Data;
using GuildWars2.NET.Core.v2.Items.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.v2.Items.Repositories
{
    public class ItemRepository : GW2Repository
    {
        public ItemRepository() : base(string.Empty) { } 
        public ItemRepository(string apiKey) : base(apiKey) { }

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
    }
}
