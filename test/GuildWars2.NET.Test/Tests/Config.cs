using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GuildWars2.NET.Test.Tests
{
    [DataContract]
    public class Config
    {
        private static IConfiguration instance { get; } = Init();

        private Config() { }

        public static string GetApiKey()
        {
            return instance?["apiKey"];
        }

        public static string GetCharacter()
        {
            return instance?["character"];
        }

        public static IConfiguration Init()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.test.json")
                                             .Build();
        }
    }
}
