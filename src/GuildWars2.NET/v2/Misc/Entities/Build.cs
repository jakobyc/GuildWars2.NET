using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Misc.Entities
{
    /// <summary>
    /// Current build version of the game.
    /// </summary>
    public class Build
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
