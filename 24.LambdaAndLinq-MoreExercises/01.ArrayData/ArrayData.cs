using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayData
{
    class ArrayData
    {
        static void Main()
        {
            List<int> initialNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine().ToLower();

            double average = initialNums.Average();

            List<int> removedNums =
                initialNums
                .Where(r => r >= average)
                .OrderBy(r => r)
                .ToList();

            if (command == "min")
            {
                int min = removedNums.Min();
                Console.WriteLine(min);
            }
            else if (command == "max")
            {
                int max = removedNums.Max();
                Console.WriteLine(max);
            }
            else if (command == "all")
            {
                Console.WriteLine(string.Join(" ", removedNums));
            }
        }
    }
}
