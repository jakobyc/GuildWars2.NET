using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GuildWars2.NET.Test.Tests
{
    public class Config
    {
        private readonly static IConfiguration instance = Init();

        private Config() { }

        public static string GetApiKey()
        {
            return instance?["apiKey"];
        }

        public static string GetCharacter()
        {
            return instance?["character"];
        }

        public static string GetGuild()
        {
            return instance?["guild"];
        }

        public static IConfiguration Init()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.test.json")
                                             .Build();
        }
    }
}
