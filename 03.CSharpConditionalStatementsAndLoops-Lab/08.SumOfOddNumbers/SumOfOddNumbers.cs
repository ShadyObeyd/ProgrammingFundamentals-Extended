using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cntr = 0;
            int sum = 0;

            for (int i = 1; ; i++)
            {
                if (i % 2 == 1)
                {
                    cntr++;
                    sum += i;
                    Console.WriteLine(i);
                }
                if (cntr == n)
                {
                    break;
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
