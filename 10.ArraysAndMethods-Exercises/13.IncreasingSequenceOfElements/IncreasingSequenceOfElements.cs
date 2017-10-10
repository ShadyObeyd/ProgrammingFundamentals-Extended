using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.IncreasingSequenceOfElements
{
    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            string result = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                result = "Yes";
                if (arr[i] > arr[i + 1])
                {
                    result = "No";
                    break;
                }
            }
            Console.WriteLine(result);
        }
    }
}

