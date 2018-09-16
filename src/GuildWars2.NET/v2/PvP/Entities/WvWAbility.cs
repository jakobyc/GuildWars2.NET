using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class WvWAbility
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("ranks")]
        public ICollection<Rank> Ranks { get; set; }

        public class Rank
        {
            [JsonProperty("cost")]
            public int Cost { get; set; }

            [JsonProperty("effect")]
            public string Effect { get; set; }
        }
    }


}
