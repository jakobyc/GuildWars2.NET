using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class CoreInformation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("race")]
        public string Race { get; set; }
        [JsonProperty("gender")]
        public string Gender { get; set; }
        [JsonProperty("profession")]
        public string Profession { get; set; }
        [JsonProperty("guild")]
        public string CurrentGuild { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("deaths")]
        public int Deaths { get; set; }
        [JsonProperty("title")]
        public int CurrentTitleId { get; set; }
    }
}