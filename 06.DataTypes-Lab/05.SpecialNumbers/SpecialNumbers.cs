using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int digits = i;
                int sum = 0;
                while (digits > 0)
                {
                    sum += digits % 10;
                    digits /= 10;
                }
                bool result = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {result}");
            }

        }
    }
}

