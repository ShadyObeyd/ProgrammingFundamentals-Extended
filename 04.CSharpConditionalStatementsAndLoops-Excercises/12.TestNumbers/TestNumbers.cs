using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.TestNumbers
{
    class TestNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int comboCntr = 0;

            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    if (sum >= maxSum)
                    {
                        break;
                    }
                    sum += i * j * 3;
                    comboCntr++;
                }
            }
            if (sum >= maxSum)
            {
                Console.WriteLine($"{comboCntr} combinations \nSum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{comboCntr} combinations \nSum: {sum}");
            }
        }
    }
}
