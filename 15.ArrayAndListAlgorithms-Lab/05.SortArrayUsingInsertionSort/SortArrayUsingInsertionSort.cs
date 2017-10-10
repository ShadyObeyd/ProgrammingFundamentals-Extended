using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortArrayUsingInsertionSort
{
    class SortArrayUsingInsertionSort
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++)
            {
                for (int secondindex = firstIndex; secondindex > 0; secondindex--)
                {
                    if (arr[secondindex - 1] > arr[secondindex])
                    {
                        Swap(ref arr[secondindex - 1], ref arr[secondindex]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr));
        }
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
