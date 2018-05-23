using GuildWars2.NET.Core.v2.Account.Repositories;
using GuildWars2.NET.Core.v2.Achievements.Repositories;
using System;

namespace GuildWars2.NET.Core.TestClient
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Input API key:");
            string apiKey = Console.ReadLine();

            Init.Start(typeof(AccountRepository), apiKey);

            Console.ReadLine();
        }
    }
}
