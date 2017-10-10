using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SmallestElementInArray
{
    class SmallestEnemyInArray
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int smallestNum = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestNum)
                {
                    smallestNum = arr[i];
                }
            }
            Console.WriteLine(smallestNum);
            

        }
    }
}
