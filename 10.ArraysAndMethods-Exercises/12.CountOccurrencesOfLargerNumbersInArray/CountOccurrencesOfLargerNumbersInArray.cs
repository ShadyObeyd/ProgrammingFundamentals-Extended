using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CountOccurrencesOfLargerNumbersInArray
{
    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double p = double.Parse(Console.ReadLine());

            int cntr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > p)
                {
                    cntr++;
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
