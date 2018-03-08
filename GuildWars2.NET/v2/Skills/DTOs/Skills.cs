using GuildWars2.NET.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.v2.Skills.DTOs
{
    public class Skills : List<Skill>, ICollection<Skill>, IRetrievable
    {
        public string Endpoint { get; private set; }

        public Skills()
        {
            Endpoint = string.Format("skills");
        }
    }
}
