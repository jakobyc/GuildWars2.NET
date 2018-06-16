using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Characters.Entities
{
    [DataContract]
    public class CoreInformation
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "race")]
        public string Race { get; set; }
        [DataMember(Name = "gender")]
        public string Gender { get; set; }
        [DataMember(Name = "profession")]
        public string Profession { get; set; }
        [DataMember(Name = "guild")]
        public string CurrentGuild { get; set; }
        [DataMember(Name = "created")]
        public string Created { get; set; }

        [DataMember(Name = "level")]
        public int Level { get; set; }
        [DataMember(Name = "age")]
        public int Age { get; set; }
        [DataMember(Name = "deaths")]
        public int Deaths { get; set; }
        [DataMember(Name = "title")]
        public int CurrentTitleId { get; set; }
    }
}