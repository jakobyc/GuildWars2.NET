using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class AccountAchievement
    {
        [JsonProperty("bits")]
        public ICollection<string> bits { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("current")]
        public int Current { get; set; }
        [JsonProperty("max")]
        public int Max { get; set; }
        [JsonProperty("repeated")]
        public int Repeated { get; set; }

        [JsonProperty("done")]
        public bool Done { get; set; }
    }
}
