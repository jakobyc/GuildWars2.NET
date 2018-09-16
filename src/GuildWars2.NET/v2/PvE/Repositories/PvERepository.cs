using GuildWars2.NET.Builders.Endpoints;
using GuildWars2.NET.Data;
using GuildWars2.NET.v2.PvE.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.v2.PvE.Repositories
{
    public class PvERepository : GW2Repository
    {
        public PvERepository() : base() { }

        public ICollection<string> GetBackstoryAnswers()
        {
            return Retrieve<ICollection<string>>("backstory/answers");
        }

        public BackstoryAnswer GetBackstoryAnswer(string id)
        {
            return Retrieve<BackstoryAnswer>($"backstory/answers/{id}");
        }

        public ICollection<BackstoryAnswer> GetBackstoryAnswers(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("backstory/answers")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<BackstoryAnswer>>(builder);
        }

        public ICollection<int> GetTraits()
        {
            return Retrieve<ICollection<int>>("traits");
        }

        public ICollection<Trait> GetTraits(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("traits")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Trait>>(builder);
        }

        public Trait GetTrait(string id)
        {
            return Retrieve<Trait>($"traits/{id}");
        }

        public ICollection<int> GetWorlds()
        {
            return Retrieve<ICollection<int>>("worlds");
        }

        public ICollection<World> GetWorlds(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("worlds")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<World>>(builder);
        }

        public World GetWorld(string id)
        {
            return Retrieve<World>($"worlds/{id}");
        }
    }
}
