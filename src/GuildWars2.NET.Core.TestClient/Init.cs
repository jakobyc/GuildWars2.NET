using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GuildWars2.NET.Core.TestClient
{
    internal class Init
    {
        public static void Start(Type type, string apiKey)
        {
            IDictionary<int, MethodInfo> methodsDictionary = new Dictionary<int, MethodInfo>();

            // Add methods to a dictionary where the key is a number for the user to input:
            MethodInfo[] methods = type.GetMethods();
            for (int i = 0; i < type.GetMethods().Length; i++)
            {
                methodsDictionary.Add(i, methods[i]);
            }

            // Output options to user:
            Console.WriteLine("Options:");
            foreach (var method in methodsDictionary)
            {
                Console.WriteLine($"{method.Key} for {method.Value.Name}");
            }

            // Get user's option:
            int choice = Convert.ToInt32(Console.ReadLine());
            MethodInfo chosenMethod = methodsDictionary.FirstOrDefault(x => x.Key == choice).Value;
            ICollection<object> parameters = new List<object>();

            // Input parameters:
            foreach (ParameterInfo param in chosenMethod.GetParameters())
            {
                Console.WriteLine($"Insert value for parameter, {param.Name}({param.ParameterType}).");

                string input = Console.ReadLine();
                object castedInput = Convert.ChangeType(input, param.ParameterType);

                parameters.Add(castedInput);
            }

            // Invoke method and get results:
            var instance = Activator.CreateInstance(type, apiKey);
            var results = chosenMethod.Invoke(instance, parameters.ToArray());

            Console.ReadLine();
        }
    }
}
