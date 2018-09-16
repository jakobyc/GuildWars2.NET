using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Entities
{
    [DataContract]
    public class Title
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "achievement")]
        public string AchievementId { get; set; }

        [DataMember(Name = "achievements")]
        public ICollection<string> AchievementIds { get; set; }
    }
}
