using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace GuildWars2.NET.TestClient
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
                Type elementType = param.ParameterType.GetElementType();

                if (param.ParameterType.IsArray)
                {
                    if (elementType == typeof(string))
                    {
                        ICollection<string> collection = HandleArrayParams<string>(param);
                        parameters.Add(collection.ToArray());
                    }
                    else if (elementType == typeof(int))
                    {
                        ICollection<int> collection = HandleArrayParams<int>(param);
                        parameters.Add(collection.ToArray());
                    }
                }
                else
                {
                    Console.WriteLine($"Insert value for parameter, {param.Name}({param.ParameterType}).");

                    string input = Console.ReadLine();
                    object castedInput = Convert.ChangeType(input, param.ParameterType);

                    parameters.Add(castedInput);
                }
            }

            object instance;
            // Invoke method and get results:
            if (!string.IsNullOrEmpty(apiKey))
            {
                instance = Activator.CreateInstance(type, apiKey);
            }
            else
            {
                instance = Activator.CreateInstance(type);
            }
            var results = chosenMethod.Invoke(instance, parameters.ToArray());

            if (results != null)
            {
                Console.WriteLine($"{chosenMethod.Name} invoked successfully.");
            }
        }

        private static ICollection<T> HandleArrayParams<T>(ParameterInfo param)
        {
            ICollection<T> collection = new List<T>();
            AddElement<T>(collection, param);

            return collection;
        }

        private static void AddElement<T>(ICollection<T> collection, ParameterInfo param)
        {
            Console.WriteLine($"Insert element value for parameter, {param.Name}({param.ParameterType}).");

            string input = Console.ReadLine();
            T castedInput = (T)Convert.ChangeType(input, param.ParameterType.GetElementType());

            collection.Add(castedInput);

            Console.WriteLine("Input 1 to add another element, anything else to continue.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddElement<T>(collection, param);
            }
        }
    }
}
