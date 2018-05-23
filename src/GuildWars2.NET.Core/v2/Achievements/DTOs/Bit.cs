using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Achievements.DTOs
{
    [DataContract]
    public class Bit
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }
    }
}
