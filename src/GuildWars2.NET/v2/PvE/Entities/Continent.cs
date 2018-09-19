using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Continent
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("continent_dims")]
        public int[] ContinentDims { get; set; }

        [JsonProperty("min_zoom")]
        public int MinZoom { get; set; }

        [JsonProperty("max_zoom")]
        public int MaxZoom { get; set; }

        [JsonProperty("floors")]
        public string[] Floors { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
