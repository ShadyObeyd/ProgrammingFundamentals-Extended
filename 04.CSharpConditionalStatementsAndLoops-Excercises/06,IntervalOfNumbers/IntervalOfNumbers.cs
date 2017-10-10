using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum > firstNum)
            {
                for (int i = firstNum; i <= secondNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = secondNum; i <= firstNum; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
