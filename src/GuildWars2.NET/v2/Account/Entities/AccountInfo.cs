using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class AccountInfo
    {
        [JsonProperty("guilds")]
        public ICollection<string> Guilds { get; set; }
        [JsonProperty("guild_leader")]
        public ICollection<string> GuildLeaderOf { get; set; }
        [JsonProperty("access")]
        public ICollection<string> Access { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }
        [JsonProperty("world")]
        public int WorldId { get; set; }
        [JsonProperty("fractal_level")]
        public int FractalLevel { get; set; }
        [JsonProperty("daily_ap")]
        public int DailyAP { get; set; }
        [JsonProperty("monthly_ap")]
        public int MonthlyAP { get; set; }
        [JsonProperty("wvw_rank")]
        public int WvwRank { get; set; }

        [JsonProperty("commander")]
        public bool Commander { get; set; }
    }
}
