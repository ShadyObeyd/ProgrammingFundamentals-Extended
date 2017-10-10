using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> numbersCnt = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!numbersCnt.Keys.Contains(numbers[i]))
                {
                    numbersCnt.Add(numbers[i], 0);
                }
                numbersCnt[numbers[i]]++;
            }

            foreach (KeyValuePair<double, int> pair in numbersCnt)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
