using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Items.DTOs
{
    [DataContract]
    public class Recipe : IRetrievable
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "output_item_id")]
        public int OutputItemId { get; set; }
        [DataMember(Name = "output_item_count")]
        public int OutputItemCount { get; set; }
        [DataMember(Name = "min_rating")]
        public int MinRating { get; set; }
        [DataMember(Name = "time_to_craft_ms")]
        public int TimeToCraftMs { get; set; }
        [DataMember(Name = "disciplines")]
        public ICollection<string> Disciplines { get; set; }
        [DataMember(Name = "flags")]
        public ICollection<string> Flags { get; set; }
        [DataMember(Name = "ingredients")]
        public ICollection<Ingredient> Ingredients { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "chat_link")]
        public string ChatLink { get; set; }

        public string Endpoint { get; private set; }

        public Recipe()
        {
            Endpoint = "recipes";
        }

        public Recipe(string id)
        {
            Endpoint = $"recipes/{id}";
        }


        [DataContract]
        public class Ingredient
        {
            [DataMember(Name = "item_id")]
            public int ItemId { get; set; }
            [DataMember(Name = "count")]
            public int Count { get; set; }
        }

    }
}
