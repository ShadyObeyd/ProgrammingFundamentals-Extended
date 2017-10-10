using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IncrementVariable
{
    class IncrementVariable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            byte var = 1;
            int cntr = 0;

            for (int i = 1; i <= n; i++)
            {
                if (var == byte.MaxValue)
                {
                    cntr++;
                }
                var++;
            }
            Console.WriteLine(var - 1);
            if (cntr > 0)
            {
                Console.WriteLine($"Overflowed {cntr} times");
            }
        }
    }
}
