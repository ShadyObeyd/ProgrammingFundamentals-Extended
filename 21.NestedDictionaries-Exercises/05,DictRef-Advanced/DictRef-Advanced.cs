using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DictRef_Advanced
{
    class DictRef_Advanced
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<int>>();
            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string key = input[0];
                string[] tokens = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!dict.ContainsKey(key))
                {
                    dict.Add(key, new List<int>());
                }

                for (int i = 0; i < tokens.Length; i++)
                {
                    int num;

                    if (int.TryParse(tokens[i], out num))
                    {
                        dict[key].Add(num);
                    }
                    else
                    {
                        if (dict.ContainsKey(tokens[i]))
                        {
                            dict[key] = new List<int>(dict[tokens[i]]);
                        }
                    }
                }
                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in dict)
            {
                if (item.Value.Count != 0)
                {
                    Console.WriteLine($"{item.Key} === {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
