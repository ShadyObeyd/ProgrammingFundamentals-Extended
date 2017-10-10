using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArraySymetry
{
    class ArraySymetry
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            string result = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[0] == arr[i])
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
