using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefaultValues
{
    class DefaultValues
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string inputKey = tokens[0];
                string inputValue = tokens[1];

                data[inputKey] = inputValue;


                input = Console.ReadLine();
            }
            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues =
                data
                .Where(kvp => kvp.Value != "null")
                .OrderByDescending(kvp => kvp.Value.Length)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Dictionary<string, string> changedValues =
                data
                .Where(kvp => kvp.Value == "null")
                .ToDictionary(kvp => kvp.Key, kvp => defaultValue);

            foreach (var item in unchangedValues)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

            foreach (var item in changedValues)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }

        }
    }
}
