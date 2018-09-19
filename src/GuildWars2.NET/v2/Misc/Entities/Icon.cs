using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Entities
{
    public class Icon
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("icon")]
        public Uri IconUri { get; set; }
    }
}
