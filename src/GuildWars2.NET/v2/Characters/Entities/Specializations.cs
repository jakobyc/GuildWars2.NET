using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class Specializations
    {
        [JsonProperty("pve")]
        public ICollection<PvE> PvESpecs { get; set; }
        [JsonProperty("pvp")]
        public ICollection<PvP> PvPSpecs { get; set; }
        [JsonProperty("wvw")]
        public ICollection<WvW> WvWSpecs { get; set; }

        public class PvE
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("traits")]
            public ICollection<int> Traits { get; set; }
        }

        public class PvP
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("traits")]
            public ICollection<int> Traits { get; set; }
        }

        public class WvW
        {
            [JsonProperty("id")]
            public int Id { get; set; }
            [JsonProperty("traits")]
            public ICollection<int> Traits { get; set; }
        }
    }
}
