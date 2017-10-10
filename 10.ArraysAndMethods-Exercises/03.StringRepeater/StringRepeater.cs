using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StringRepeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            int inputCntr = int.Parse(Console.ReadLine());

            RepeatString(inputStr, inputCntr);
        }
        static string RepeatString(string str, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(str);
            }
            Console.WriteLine();
            return str;
        }
    }
}
