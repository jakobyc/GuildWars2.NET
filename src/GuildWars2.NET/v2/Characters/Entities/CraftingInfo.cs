using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Serialization.JSON;

namespace GuildWars2.NET.v2.Characters.Entities
{
    [DataContract]
    public class CraftingInfo
    {
        [DataMember(Name="crafting")]
        public ICollection<DisciplineInfo> Disciplines { get; set; }
    }
}