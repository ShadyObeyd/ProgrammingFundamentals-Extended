using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._0X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', i) + "x" + new string(' ', n - 2 - (2 * i)) + "x");
            }
            Console.WriteLine(new string(' ', n / 2) + "x" + new string(' ', n / 2));
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string(' ', n / 2 - 1 - i) + "x" + new string(' ', 1 + 2 * i) + "x");
            }
        }
    }
}
