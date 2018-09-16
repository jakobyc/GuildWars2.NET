using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    [DataContract]
    public class Story
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "season")]
        public string Season { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "timeline")]
        public string Timeline { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }
        [DataMember(Name = "order")]
        public int Order { get; set; }

        [DataMember(Name = "races")]
        public ICollection<string> Races { get; set; }

        [DataMember(Name = "chapters")]
        public ICollection<Chapter> Chapters { get; set; }

        [DataContract]
        public class Chapter
        {
            [DataMember(Name = "name")]
            public string Name { get; set; }
        }
    }
}
