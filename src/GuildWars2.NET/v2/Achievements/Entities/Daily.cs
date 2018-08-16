using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Achievements.Entities
{
    [DataContract]
    public class Daily
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "level")]
        public Level LevelRange { get; set; }

        [DataMember(Name = "required_access")]
        public ICollection<string> RequiredAccess { get; set; }

        public class Level
        {
            [DataMember(Name = "min")]
            public int Min { get; set; }
            [DataMember(Name = "max")]
            public int Max { get; set; }
        }
    }
}
