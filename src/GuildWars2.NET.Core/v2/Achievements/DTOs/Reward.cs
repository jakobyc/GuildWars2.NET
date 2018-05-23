using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Achievements.DTOs
{
    [DataContract]
    public class Reward
    {
        /// <summary>
        /// If type = Coins, Count property will be populated.
        /// If type = Item, Id and Count properties will be populated.
        /// If type = Mastery, Id and Region properties will be populated.
        /// If type = Title, Id property will be populated.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "region")]
        public string Region { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
