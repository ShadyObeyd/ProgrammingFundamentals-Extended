using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CountOfNegativeElementsInArray
{
    class CountOfNegativeElementsInArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int negativeCntr = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] < 0)
                {
                    negativeCntr++;
                }
            }
            Console.WriteLine(negativeCntr);
        }
    }
}
