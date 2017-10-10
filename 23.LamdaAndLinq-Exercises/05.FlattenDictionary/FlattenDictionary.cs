using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FlattenDictionary
{
    class FlattenDictionary
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                if (tokens[0] == "flatten")
                {
                    string keyToFlatten = tokens[1];
                    data[keyToFlatten] = 
                        data[keyToFlatten]
                        .ToDictionary(kvp => kvp.Key + kvp.Value, v => "flattened");
                }
                else
                {
                    string key = tokens[0];
                    string innerKey = tokens[1];
                    string innerValue = tokens[2];

                    if (!data.ContainsKey(key))
                    {
                        data.Add(key, new Dictionary<string, string>());
                    }
                    data[key][innerKey] = innerValue;
                }

                input = Console.ReadLine();
            }
            var sortedData =
                data
                .OrderByDescending(k => k.Key.Length)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var item in sortedData)
            {
                int possitionCntr = 1;
                string key = item.Key;

                Dictionary<string, string> innerData = item.Value;

                Console.WriteLine(key);

                var unflattenedData = 
                    innerData
                    .Where(r => r.Value != "flattened")
                    .OrderBy(r => r.Key.Length)
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                var flattenedData = 
                    innerData
                    .Where(r => r.Value == "flattened");


                foreach (var unflattened in unflattenedData)
                {
                    Console.WriteLine($"{possitionCntr}. { unflattened.Key} - {unflattened.Value}");
                    possitionCntr++;
                }

                foreach (var flattened in flattenedData)
                {
                    Console.WriteLine($"{possitionCntr}. {flattened.Key}");
                    possitionCntr++;
                }
            }
        }
    }
}
