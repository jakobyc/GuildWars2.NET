using GuildWars2.NET.Test.Dependencies;
using GuildWars2.NET.v2.Skills.Entities;
using GuildWars2.NET.v2.Skills.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class SkillTest : ApiTest
    {
        private SkillRepository repository;

        public SkillTest(RepositoryFactory factory)
        {
            this.repository = factory.GetSkillRepository();
        }

        [Fact]
        public void GetSkillIds()
        {
            AssertIds<List<string>>(repository.GetSkillIds());
        }

        [Fact]
        public void GetLegendIds()
        {
            AssertIds<List<string>>(repository.GetLegendIds());
        }

        [Fact]
        public void GetLegends()
        {
            string[] legends = repository.GetLegendIds().ToArray();
            AssertCall<List<Legend>>(repository.GetLegends(legends));
        }

        [Theory]
        [InlineData("Legend2")]
        public void GetLegend(string id)
        {
            AssertCall<Legend>(repository.GetLegend(id));
        }

        [Theory]
        [InlineData("29209", "28231")]
        public void GetSkills(params string[] ids)
        {
            AssertCall<List<Skill>>(repository.GetSkills(ids));
        }
    }
}
