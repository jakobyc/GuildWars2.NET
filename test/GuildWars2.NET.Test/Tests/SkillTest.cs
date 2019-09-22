using GuildWars2.NET.v2.Skills.Entities;
using GuildWars2.NET.v2.Skills.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public class SkillTest : ApiTest
    {
        private readonly ISkillRepository repository;

        public SkillTest()
        {
            this.repository = Client.Skills;
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

        #region Async
        [Fact]
        public async Task GetSkillIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetSkillIdsAsync());
        }

        [Fact]
        public async Task GetLegendIdsAsync()
        {
            AssertIds<List<string>>(await repository.GetLegendIdsAsync());
        }

        [Fact]
        public async Task GetLegendsAsync()
        {
            string[] legends = repository.GetLegendIds().ToArray();
            AssertCall<List<Legend>>(await repository.GetLegendsAsync(legends));
        }

        [Theory]
        [InlineData("Legend2")]
        public async Task GetLegendAsync(string id)
        {
            AssertCall<Legend>(await repository.GetLegendAsync(id));
        }

        [Theory]
        [InlineData("29209", "28231")]
        public async Task GetSkillsAsync(params string[] ids)
        {
            AssertCall<List<Skill>>(await repository.GetSkillsAsync(ids));
        }
        #endregion
    }
}
