using System;
using System.Collections.Generic;
using System.Text;

namespace GuildWars2.NET.Core.Serialization.JSON
{
    public class ApiEndpoint : IRetrievable
    {
        public string Endpoint { get; set; }
        public string AccessToken { get; set; }

        private ICollection<string> parameters;
        public ICollection<string> Parameters
        {
            get
            {
                return parameters = parameters ?? new List<string>();
            }
            set
            {
                parameters = value;
            }
        }
    }
}
