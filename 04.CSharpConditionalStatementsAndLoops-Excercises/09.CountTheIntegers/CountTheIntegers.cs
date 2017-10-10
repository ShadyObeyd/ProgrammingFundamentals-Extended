using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            int integerCntr = 0;
            while (true)
            {
                try
                {
                    int isInteger = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine(integerCntr);
                    break;
                }
                integerCntr++;
            }
        }
    }
}
