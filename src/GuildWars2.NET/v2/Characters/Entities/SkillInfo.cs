using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GuildWars2.NET.v2.Characters.Entities
{
    public class SkillInfo
    {
        [JsonProperty("pve")]
        public SkillPvE PvE { get; set; }
        [JsonProperty("pvp")]
        public SkillPvP PvP { get; set; }
        [JsonProperty("wvw")]
        public SkillWvW WvW { get; set; }
    }
}