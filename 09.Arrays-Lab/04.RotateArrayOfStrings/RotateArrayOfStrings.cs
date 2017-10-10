using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RotateArrayOfStrings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            string[] resultArr = new string[arr.Length];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                resultArr[i + 1] = arr[i];
            }
            string lastElement = arr.Last();

            resultArr[0] = lastElement;

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
