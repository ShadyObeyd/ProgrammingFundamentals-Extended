using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.IntegerToBase
{
    class IntegerToBase
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int inputBase = int.Parse(Console.ReadLine());

            Console.WriteLine(NumToBase(inputNum, inputBase));
        }
        static string NumToBase(int num, int toBase)
        {
            string result = string.Empty;

            while (num > 0)
            {
                int remainder = num % toBase;
                result = remainder + result;
                num /= toBase;
            }
            return result;
        }
    }
}
