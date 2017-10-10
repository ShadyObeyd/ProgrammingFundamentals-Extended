using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactProductOfRealNumbers
{
    class ExactProductOfRealNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 1m;

            for (int i = 0; i < n; i++)
            {
                decimal numbers = decimal.Parse(Console.ReadLine());
                sum *= numbers;
            }
            Console.WriteLine(sum);
        }
    }
}
