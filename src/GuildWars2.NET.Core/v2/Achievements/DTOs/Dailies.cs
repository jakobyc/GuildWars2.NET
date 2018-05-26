using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace GuildWars2.NET.Core.v2.Achievements.DTOs
{
    [DataContract]
    public class Dailies : IRetrievable
    {
        [DataMember(Name = "pve")]
        public ICollection<Daily> PvE { get; set; }
        [DataMember(Name = "pvp")]
        public ICollection<Daily> PvP { get; set; }
        [DataMember(Name = "wvw")]
        public ICollection<Daily> WvW { get; set; }
        [DataMember(Name = "fractals")]
        public ICollection<Daily> Fractals { get; set; }
        [DataMember(Name = "special")]
        public ICollection<Daily> Special { get; set; }

        public string Endpoint { get; private set; }

        public Dailies()
        {
            Endpoint = "achievements/daily";
        }

        public Dailies(bool tomorrow)
        {
            if (tomorrow)
            {
                Endpoint = "achievements/daily/tomorrow";
            }
            else
            {
                Endpoint = "achievements/daily";
            }
        }
    }
}
