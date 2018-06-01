using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Xunit;

namespace GuildWars2.NET.Test.Tests
{
    [DataContract]
    public class Config
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; private set; }

        [Fact]
        public static Config Load()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            int index = path.IndexOf("\\GuildWars2.NET\\");
            if (index != -1)
            {
                // Get root:
                path = path.Substring(0, index + ("\\GuildWars2.NET\\".Length));
                // Append 
                path += "test\\GuildWars2.NET.Test\\Tests\\config.json";

                Assert.True(File.Exists(path), $"File not found at the set path ({path}).");
                if (File.Exists(path))
                {
                    using (FileStream stream = new FileStream(path, FileMode.Open))
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            JsonDeserializer deserializer = new JsonDeserializer();

                            string json = reader.ReadToEnd();
                            Config config = deserializer.Deserialize<Config>(json);
                            Assert.NotNull(config.ApiKey);

                            return config;
                        }
                    }
                }
            }
            return null;
        }
    }
}
