using GuildWars2.NET.Core.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GuildWars2.NET.Builders.Endpoints
{
    public class EndpointBuilder : IEndpointBuilder
    {
        private string resource;
        private bool hasParameter = false;

        public EndpointBuilder() { }

        public EndpointBuilder(string endpoint)
        {
            resource = endpoint;
        }

        public IEndpointBuilder AddEndpoint(string endpoint)
        {
            resource = endpoint;

            return this;
        }

        public IEndpointBuilder AddParameter(string parameterName, string[] values)
        {
            if (values != null)
            {
                string parameter = $"?{parameterName}=";

                if (hasParameter)
                {
                    parameter = $"&{parameterName}=";
                }

                foreach (string value in values)
                {
                    parameter += $"{value},";
                }
                parameter = parameter.Remove(parameter.LastIndexOf(","));

                resource += parameter;
                hasParameter = true;
            }
            return this;
        }

        public IEndpointBuilder AddParameter(string parameterName, int[] values)
        {
            AddParameter(parameterName, values.Select(x => x.ToString()).ToArray());

            return this;
        }


        public string Build()
        {
            string temp = resource;

            // Reset the resource so the builder can be used again:
            resource = string.Empty;

            return temp;
        }
    }
}
