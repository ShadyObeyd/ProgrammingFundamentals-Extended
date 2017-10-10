using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int largestNum = 0;
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > largestNum)
                {
                    largestNum = arr[i];
                }
            }
            Console.WriteLine(largestNum);
        }
    }
}
