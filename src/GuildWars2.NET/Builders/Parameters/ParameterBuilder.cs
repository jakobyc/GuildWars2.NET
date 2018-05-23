using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Builders.Parameters
{
    public class ParameterBuilder : IParameterBuilder
    {
        private string parameter;

        public ParameterBuilder()
        {
            parameter = string.Empty;
        }


        public string Build(string parameterName, int[] queryValues)
        {
            string[] queryValuesParsed = queryValues.Select(x => x.ToString()).ToArray();

            return Build(parameterName, queryValuesParsed);
        }

        /// <summary>
        /// Returns a query string parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter used in the query string.</param>
        /// <param name="queryValues">Values associated with the parameter name.</param>
        public string Build(string parameterName, string[] queryValues)
        {
            string parameter = parameterName + "=";
            if (queryValues != null)
            {
                for (int i = 0; i < queryValues.Length; i++)
                {
                    // If the current index is not the last:
                    if (i < queryValues.Length - 1)
                    {
                        parameter += queryValues[i] + ',';
                    }
                    // Else don't add a comma
                    else
                    {
                        parameter += queryValues[i];
                    }
                }
            }
            return parameter;
        }

        /// <summary>
        /// Returns a query string parameter.
        /// </summary>
        public string Build()
        {
            return parameter;
        }
    }
}
