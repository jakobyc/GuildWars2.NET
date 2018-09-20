using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Account.Entities
{
    public class PvPStats
    {
        [JsonProperty("pvp_rank")]
        public int PvpRank { get; set; }

        [JsonProperty("pvp_rank_points")]
        public int PvpRankPoints { get; set; }

        [JsonProperty("pvp_rank_rollovers")]
        public int PvpRankRollovers { get; set; }

        [JsonProperty("aggregate")]
        public Aggregate Aggregate { get; set; }

        [JsonProperty("professions")]
        public Professions Professions { get; set; }

        [JsonProperty("ladders")]
        public Ladders Ladders { get; set; }
    }

    public class Aggregate
    {
        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("desertions")]
        public int Desertions { get; set; }

        [JsonProperty("byes")]
        public int Byes { get; set; }

        [JsonProperty("forfeits")]
        public int Forfeits { get; set; }
    }

    public class Ladders
    {
        [JsonProperty("ranked")]
        public Aggregate Ranked { get; set; }

        [JsonProperty("soloarenarated")]
        public Aggregate Soloarenarated { get; set; }

        [JsonProperty("teamarenarated")]
        public Aggregate Teamarenarated { get; set; }

        [JsonProperty("unranked")]
        public Aggregate Unranked { get; set; }
    }

    public class Professions
    {
        [JsonProperty("elementalist")]
        public Aggregate Elementalist { get; set; }

        [JsonProperty("engineer")]
        public Aggregate Engineer { get; set; }

        [JsonProperty("mesmer")]
        public Aggregate Mesmer { get; set; }

        [JsonProperty("necromancer")]
        public Aggregate Necromancer { get; set; }

        [JsonProperty("ranger")]
        public Aggregate Ranger { get; set; }

        [JsonProperty("thief")]
        public Aggregate Thief { get; set; }

        [JsonProperty("warrior")]
        public Aggregate Warrior { get; set; }
    }
}
