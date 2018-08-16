using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    [DataContract]
    public class BackstoryAnswer
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "journal")]
        public string Journal { get; set; }

        [DataMember(Name = "professions")]
        public ICollection<string> Professions { get; set; }
        [DataMember(Name = "races")]
        public ICollection<string> Races { get; set; }

        [DataMember(Name = "question")]
        public int Question { get; set; }

    }
}
