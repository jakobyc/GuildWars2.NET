using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using GuildWars2.NET.Core.Serialization.JSON;

namespace GuildWars2.NET.Core.v2.Characters.DTOs
{
    [DataContract]
    public class HeroPoint : IRetrievable
    {
        public string Endpoint { get; private set; }

        public HeroPoint(string characterName)
        {
            this.Endpoint = string.Format("characters/{0}/heropoints", characterName);
        }
    }
}