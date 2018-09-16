using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class WvWObjective
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("map_type")]
        public string Map_type { get; set; }
        [JsonProperty("marker")]
        public string Marker { get; set; }
        [JsonProperty("chat_link")]
        public string ChatLink { get; set; }

        [JsonProperty("sector_id")]
        public int SectorId { get; set; }
        [JsonProperty("map_id")]
        public int MapId { get; set; }
        [JsonProperty("upgrade_id")]
        public int UpgradeId { get; set; }

        [JsonProperty("coord")]
        public ICollection<double> Coord { get; set; }
        [JsonProperty("label_coord")]
        public ICollection<double> LabelCoord { get; set; }

    }
}
