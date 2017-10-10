using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string result = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            Console.WriteLine(result);
        }
    }
}
