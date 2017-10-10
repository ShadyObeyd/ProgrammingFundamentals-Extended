using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SignOfIntegerNumber
{
    class SignOfIntegerNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SignOfNumber(n);
        }
        static void SignOfNumber(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }
            else
            {
                Console.WriteLine("The number {0} is zero.", num);
            }
        }
    }
}
