using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    [DataContract]
    public class StorySeason
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "order")]
        public int Order { get; set; }

        /// <summary>
        /// Collection of story id's associated with the selected Season
        /// </summary>
        [DataMember(Name = "stories")]
        public ICollection<string> StoryIds { get; set; }
    }
}
