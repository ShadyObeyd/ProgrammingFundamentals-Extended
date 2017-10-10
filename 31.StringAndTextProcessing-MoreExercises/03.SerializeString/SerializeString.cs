using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SerializeString
{
    class SerializeString
    {
        static void Main()
        {
            Dictionary<char, List<int>> data = new Dictionary<char, List<int>>();

            string input = Console.ReadLine();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (!data.ContainsKey(input[i]))
                {
                    data.Add(input[i], new List<int>());
                    int index = -1;

                    while ((index = input.IndexOf(input[i], index + 1)) > -1)
                    {
                        data[input[i]].Add(index);
                    }
                }
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key}:{string.Join("/", item.Value)}");
            }
        }
    }
}
