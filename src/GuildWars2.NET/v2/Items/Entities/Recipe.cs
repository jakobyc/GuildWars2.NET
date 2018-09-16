using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Items.Entities
{
    public class Recipe
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("output_item_id")]
        public int OutputItemId { get; set; }
        [JsonProperty("output_item_count")]
        public int OutputItemCount { get; set; }
        [JsonProperty("min_rating")]
        public int MinRating { get; set; }
        [JsonProperty("time_to_craft_ms")]
        public int TimeToCraftMs { get; set; }
        [JsonProperty("disciplines")]
        public ICollection<string> Disciplines { get; set; }
        [JsonProperty("flags")]
        public ICollection<string> Flags { get; set; }
        [JsonProperty("ingredients")]
        public ICollection<Ingredient> Ingredients { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }

        public class Ingredient
        {
            [JsonProperty("item_id")]
            public int ItemId { get; set; }
            [JsonProperty("count")]
            public int Count { get; set; }
        }

    }
}
