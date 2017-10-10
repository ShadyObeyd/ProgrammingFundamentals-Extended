using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DeserializeString
{
    class DeserializeString
    {
        static void Main()
        {
            SortedDictionary<int, char> data = new SortedDictionary<int, char>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(':');

                char @char = tokens[0][0];
                int[] indicies = tokens[1].Split('/').Select(int.Parse).ToArray();

                foreach (var index in indicies)
                {
                    data[index] = @char;
                }

                input = Console.ReadLine();
            }

            foreach (var item in data)
            {
                Console.Write(item.Value);
            }
            Console.WriteLine();
        }
    }
}
