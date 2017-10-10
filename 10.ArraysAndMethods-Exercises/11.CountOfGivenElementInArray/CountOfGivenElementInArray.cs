using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CountOfGivenElementInArray
{
    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            int cntr = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    cntr++;
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
