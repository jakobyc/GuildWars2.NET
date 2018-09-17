﻿using GuildWars2.NET.Builders.Endpoints;
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

        public ICollection<string> GetRaces()
        {
            return Retrieve<ICollection<string>>("races");
        }

        public ICollection<Race> GetRaces(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("races")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Race>>(builder);
        }

        public Race GetRace(string id)
        {
            return Retrieve<Race>($"races/{id}");
        }

        public ICollection<string> GetRaids()
        {
            return Retrieve<ICollection<string>>("raids");
        }

        public ICollection<Raid> GetRaids(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("raids")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Raid>>(builder);
        }

        public Raid GetRaid(string id)
        {
            return Retrieve<Raid>($"raids/{id}");
        }

        public ICollection<Specialization> GetSpecializations(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("specializations")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Specialization>>(builder);
        }

        public Specialization GetSpecialization(string id)
        {
            return Retrieve<Specialization>($"specializations/{id}");
        }

        public ICollection<string> GetStories()
        {
            return Retrieve<ICollection<string>>("stories");
        }

        public ICollection<Story> GetStories(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<Story>>(builder);
        }

        public Story GetStory(string id)
        {
            return Retrieve<Story>($"stories/{id}");
        }

        public ICollection<string> GetStorySeasons()
        {
            return Retrieve<ICollection<string>>("stories/seasons");
        }

        public ICollection<StorySeason> GetStorySeasons(params string[] ids)
        {
            IEndpointBuilder builder = new EndpointBuilder().AddEndpoint("stories/seasons")
                                                            .AddParameter("ids", ids);
            return Retrieve<ICollection<StorySeason>>(builder);
        }

        public StorySeason GetStorySeason(string id)
        {
            return Retrieve<StorySeason>($"stories/seasons/{id}");
        }

        public ICollection<string> GetTraits()
        {
            return Retrieve<ICollection<string>>("traits");
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
