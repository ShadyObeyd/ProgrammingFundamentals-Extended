using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Last3ConsecutiveEqualStrings
{
    class Last3ConsecutiveEqualStrings
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            string consecutiveString = string.Empty;
            
            for (int i = 0; i < arr.Length - 2; i++)
            {
                
                if (arr[i] == arr[i + 1] && arr[i] == arr[i + 2] && arr[i + 1] == arr[i + 2])
                {
                    consecutiveString = arr[i];
                }
            }
            Console.WriteLine($"{consecutiveString} {consecutiveString} {consecutiveString}");
        }
    }
}
