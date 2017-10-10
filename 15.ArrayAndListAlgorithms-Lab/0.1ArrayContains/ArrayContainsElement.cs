using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1ArrayContains
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == n)
                {
                    isFound = true;
                }
            }
            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
