using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.v2.Achievements.Entities
{
    [DataContract]
    public class Category
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "description")]
        public string Description { get; set; }
        [DataMember(Name = "icon")]
        public string Icon { get; set; }

        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "order")]
        public int Order { get; set; }

        [DataMember(Name = "achievements")]
        public ICollection<int> Achievements { get; set; }
    }
}
