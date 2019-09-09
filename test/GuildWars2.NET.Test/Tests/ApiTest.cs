using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public abstract class ApiTest
    {
        public GW2Client Client { get; }

        public ApiTest()
        {
            Client = new GW2Client(Config.GetApiKey());
        }

        protected void AssertCall<T>(object o)
        {
            Assert.IsType<T>(o);
            Assert.NotNull(o);
        }

        protected void AssertIds<T>(object o) where T : IEnumerable
        {
            AssertCall<T>(o);
            
            Assert.NotEmpty(o as IEnumerable);
        }
    }
}
