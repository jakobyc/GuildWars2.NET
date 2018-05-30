using GuildWars2.NET.Core.v2.Account.Repositories;
using GuildWars2.NET.Core.v2.Achievements.Repositories;
using GuildWars2.NET.Core.v2.Characters.Repositories;
using GuildWars2.NET.Core.v2.Items.Repositories;
using GuildWars2.NET.Core.v2.PvE.Repositories;
using GuildWars2.NET.Core.v2.PvP.Repositories;
using GuildWars2.NET.Core.v2.Skills.Repositories;
using System;

namespace GuildWars2.NET.Core.TestClient
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            Console.WriteLine("Input API key:");
            string apiKey = Console.ReadLine();

            Initialize(apiKey);
        }

        public static void Initialize(string apiKey)
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine("Options:");
            Console.WriteLine("1 for AccountRepository");
            Console.WriteLine("2 for AchievementRepository");
            Console.WriteLine("3 for CharacterRepository");
            Console.WriteLine("4 for SkillRepository");
            Console.WriteLine("5 for ItemRepository");
            Console.WriteLine("6 for PvERepository");
            Console.WriteLine("7 for PvPRepository");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case ("1"):
                    Init.Start(typeof(AccountRepository), apiKey);
                    break;
                case ("2"):
                    Init.Start(typeof(AchievementRepository), apiKey);
                    break;
                case ("3"):
                    Init.Start(typeof(CharacterRepository), apiKey);
                    break;
                case ("4"):
                    Init.Start(typeof(SkillRepository), apiKey);
                    break;
                case ("5"):
                    Init.Start(typeof(ItemRepository), apiKey);
                    break;
                case ("6"):
                    Init.Start(typeof(PvERepository), apiKey);
                    break;
                case ("7"):
                    Init.Start(typeof(PvPRepository), apiKey);
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Input 1 to restart application, or anything else to exit.");
            string endChoice = Console.ReadLine();

            if (endChoice == "1")
            {
                Initialize(apiKey);
            }
        }
    }
}
