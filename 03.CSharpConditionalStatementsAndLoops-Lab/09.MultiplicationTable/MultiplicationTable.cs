using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplicationTable
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = 0;

            while (multiplier >=0 && multiplier < 10)
            {
                multiplier++;
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            }
        }
    }
}
