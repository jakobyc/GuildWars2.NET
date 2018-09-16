using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class WvWUpgrade
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "tiers")]
        public ICollection<WvWUpgradeTier> Tiers { get; set; }

        [DataContract]
        public class WvWUpgradeTier
        {
            [DataMember(Name = "name")]
            public string Name { get; set; }

            [DataMember(Name = "yaks_required")]
            public int YaksRequired { get; set; }

            [DataMember(Name = "upgrades")]
            public ICollection<TierUpgrade> Upgrades { get; set; }

            [DataContract]
            public class TierUpgrade
            {
                [DataMember(Name = "name")]
                public string Name { get; set; }
                [DataMember(Name = "description")]
                public string Description { get; set; }
                [DataMember(Name = "icon")]
                public string Icon { get; set; }
            }
        }
    }


}
