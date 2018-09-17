using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Map
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("min_level")]
        public int MinLevel { get; set; }

        [JsonProperty("max_level")]
        public int MaxLevel { get; set; }

        [JsonProperty("default_floor")]
        public int DefaultFloor { get; set; }

        [JsonProperty("floors")]
        public int[] Floors { get; set; }

        [JsonProperty("region_id")]
        public string RegionId { get; set; }

        [JsonProperty("region_name")]
        public string RegionName { get; set; }

        [JsonProperty("continent_id")]
        public string ContinentId { get; set; }

        [JsonProperty("continent_name")]
        public string ContinentName { get; set; }

        [JsonProperty("map_rect")]
        public int[][] MapRect { get; set; }

        [JsonProperty("continent_rect")]
        public int[][] ContinentRect { get; set; }
    }
}
