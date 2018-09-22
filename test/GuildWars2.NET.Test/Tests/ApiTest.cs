using GuildWars2.NET.Test.Dependencies;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    public abstract class ApiTest: IClassFixture<RepositoryFactory>
    {
        protected void AssertCall<T>(object o)
        {            Assert.IsType<T>(o);

            Assert.NotNull(o);
        }

        protected void AssertIds<T>(object o) where T : IEnumerable
        {
            AssertCall<T>(o);
            
            Assert.NotEmpty(o as IEnumerable);
        }
    }
}
