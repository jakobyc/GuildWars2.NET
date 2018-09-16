using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    [DataContract]
    public class Specialization
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "profession")]
        public string Profession { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }
        [DataMember(Name = "background")]
        public string Background { get; set; }

        [DataMember(Name = "elite")]
        public bool Elite { get; set; }

        [DataMember(Name = "minor_traits")]
        public ICollection<string> MinorTraitIds { get; set; }
        [DataMember(Name = "major_traits")]
        public ICollection<string> MajorTraitIds { get; set; }
    }
}
