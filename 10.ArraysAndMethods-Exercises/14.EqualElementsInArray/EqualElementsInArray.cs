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

            int[] newArr = new int[arr.Length];

            string result = string.Empty;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArr[i] = arr[i + 1];
                if (newArr[i] == arr[i])
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                }
            }
            Console.WriteLine(result);
        }
    }
}
