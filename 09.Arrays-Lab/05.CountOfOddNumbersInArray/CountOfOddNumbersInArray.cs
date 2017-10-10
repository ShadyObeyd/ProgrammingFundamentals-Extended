using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CountOfOddNumbersInArray
{
    class CountOfOddNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int oddCntr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1 || arr[i] % 2 == -1)
                {
                    oddCntr++;
                }
            }
            Console.WriteLine(oddCntr);
        }
    }
}
