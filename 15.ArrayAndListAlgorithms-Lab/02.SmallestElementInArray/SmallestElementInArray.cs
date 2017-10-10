using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SmallestElementInArray
{
    class SmallestElementInArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minElement = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minElement)
                {
                    minElement = arr[i];
                }
            }
            Console.WriteLine(minElement);
        }
    }
}
