using System;

namespace GuildWars2.NET.TestClient
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

            GW2Client client = new GW2Client(apiKey);
      
            switch (choice)
            {
                case ("1"):
                    Init.Start(client.Account.GetType(), apiKey);
                    break;
                case ("2"):
                    Init.Start(client.Achievements.GetType(), string.Empty);
                    break;
                case ("3"):
                    Init.Start(client.Characters.GetType(), apiKey);
                    break;
                case ("4"):
                    Init.Start(client.Skills.GetType(), string.Empty);
                    break;
                case ("5"):
                    Init.Start(client.Items.GetType(), string.Empty);
                    break;
                case ("6"):
                    Init.Start(client.PvE.GetType(), string.Empty);
                    break;
                case ("7"):
                    Init.Start(client.PvP.GetType(), string.Empty);
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
