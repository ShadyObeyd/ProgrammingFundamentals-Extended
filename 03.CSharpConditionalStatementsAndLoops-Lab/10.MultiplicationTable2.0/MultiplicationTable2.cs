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
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            while (true)
            {
                if (multiplier > 9)
                {
                    Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                    break;
                }
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;
            }

        }
    }
}
