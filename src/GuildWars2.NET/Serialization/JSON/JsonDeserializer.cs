using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace GuildWars2.NET.Serialization.JSON
{
    public class JsonDeserializer
    {
        public TType Deserialize<TType>(string json)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(TType));

            using (MemoryStream stream = new MemoryStream(Encoding.Default.GetBytes(json)))
            {
                return (TType)serializer.ReadObject(stream);
            }
        }
    }
}
