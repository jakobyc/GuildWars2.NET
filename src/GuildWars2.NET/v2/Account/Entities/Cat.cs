using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class Cat
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }
    }
}
