using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Entities
{
    public class Specialization
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("profession")]
        public string Profession { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("background")]
        public string Background { get; set; }

        [JsonProperty("elite")]
        public bool Elite { get; set; }

        [JsonProperty("minor_traits")]
        public ICollection<string> MinorTraitIds { get; set; }
        [JsonProperty("major_traits")]
        public ICollection<string> MajorTraitIds { get; set; }
    }
}
