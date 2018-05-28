using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildWars2.NET.Core.Serialization.JSON
{
    public interface IRetrievable
    {
        string Endpoint { get; }
        ICollection<string> Parameters { get; }
        string AccessToken { get; }
    }
}
