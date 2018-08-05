using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvP.Entities
{
    [DataContract]
    public class WvWObjective
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "map_type")]
        public string Map_type { get; set; }
        [DataMember(Name = "marker")]
        public string Marker { get; set; }
        [DataMember(Name = "chat_link")]
        public string ChatLink { get; set; }

        [DataMember(Name = "sector_id")]
        public int SectorId { get; set; }
        [DataMember(Name = "map_id")]
        public int MapId { get; set; }
        [DataMember(Name = "upgrade_id")]
        public int Upgrade_id { get; set; }

        [DataMember(Name = "coord")]
        public ICollection<double> Coord { get; set; }
        [DataMember(Name = "label_coord")]
        public ICollection<double> LabelCoord { get; set; }

    }
}
