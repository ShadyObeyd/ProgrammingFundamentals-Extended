using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MultiplicationTable2._0
{
    class MultiplicationTable2
    {
        static void Main(string[] args)
        {
            do
            {
                int n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 1)
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Please write an odd number.");
                }
            } while (true);

        }
    }
}
