using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.Guilds.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.Guilds.Repositories
{
    public class GuildRepository : GW2Repository
    {
        public GuildRepository() : base() { }

        public ICollection<string> GetBackgroundEmblems()
        {
            return Retrieve<ICollection<string>>("emblem/backgrounds");
        }

        public ICollection<Emblem> GetBackgroundEmblems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/backgrounds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Emblem>>(builder);
        }

        public Emblem GetBackgroundEmblem(string id)
        {
            return Retrieve<Emblem>($"emblem/backgrounds/{id}");
        }

        public ICollection<string> GetForegroundEmblems()
        {
            return Retrieve<ICollection<string>>("emblem/foregrounds");
        }

        public ICollection<Emblem> GetForegroundEmblems(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("emblem/foregrounds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Emblem>>(builder);
        }

        public Emblem GetForegroundEmblem(string id)
        {
            return Retrieve<Emblem>($"emblem/foregrounds/{id}");
        }
    }
}
