using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    public class WvWUpgrade
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tiers")]
        public ICollection<WvWUpgradeTier> Tiers { get; set; }

        public class WvWUpgradeTier
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("yaks_required")]
            public int YaksRequired { get; set; }

            [JsonProperty("upgrades")]
            public ICollection<TierUpgrade> Upgrades { get; set; }

            public class TierUpgrade
            {
                [JsonProperty("name")]
                public string Name { get; set; }
                [JsonProperty("description")]
                public string Description { get; set; }
                [JsonProperty("icon")]
                public string Icon { get; set; }
            }
        }
    }


}
