using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Linquistics
{
    class Linquistics
    {
        static void Main()
        {
            Dictionary<string, List<string>> data = new Dictionary<string, List<string>>();

            string[] tokens;
            string input = Console.ReadLine();

            while (input != "exit")
            {
                tokens = input.Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                string collection = tokens[0];
                string[] methods = tokens.Skip(1).ToArray();
                int number;

                if (methods.Length > 0)
                {

                    foreach (var method in methods)
                    {
                        if (!data.ContainsKey(collection))
                        {
                            data.Add(collection, new List<string>());
                        }

                        if (!data[collection].Contains(method))
                        {
                            data[collection].Add(method);
                        }
                    }
                }
                else if (int.TryParse(collection, out number))
                {
                    if (data.Count > 0)
                    {
                        var collectionWithMostMethods =
                            data
                            .OrderByDescending(v => v.Value.Count)
                            .First();

                        var methodsToPrint =
                            collectionWithMostMethods.Value
                            .OrderBy(v => v.Length)
                            .Take(number);

                        Print(methodsToPrint);
                    }
                }
                else if (data.ContainsKey(collection))
                {
                    var methodsToPrint =
                        data[collection]
                        .OrderByDescending(m => m.Length)
                        .ThenByDescending(m => m.Distinct().Count());

                    Print(methodsToPrint);
                }

                input = Console.ReadLine();
            }

            string[] inputTokens = Console.ReadLine().Split(' ');

            string methodToCheck = inputTokens[0];
            string selection = inputTokens[1];

            var collectionsToPrint =
                data
                .Where(v => v.Value.Contains(methodToCheck))
                .OrderByDescending(v => v.Value.Count)
                .ThenByDescending(d => d.Value.OrderBy(m => m.Length).First().Length);

            foreach (var collections in collectionsToPrint)
            {
                string collection = collections.Key;
                List<string> methods = collections.Value;

                var orderedMethods =
                    methods
                    .OrderByDescending(m => m.Length);

                Console.WriteLine(collection);

                if (selection == "all")
                {
                    Print(orderedMethods);
                }
            }
        }
        static void Print(IEnumerable<string> methods)
        {
            foreach (var method in methods)
            {
                Console.WriteLine($"* {method}");
            }
        }
    }
}
