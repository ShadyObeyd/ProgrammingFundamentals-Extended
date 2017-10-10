using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinMethod
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondtNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestOfTheFirstTwo = GetMin(firstNum, secondtNum);

            if (smallestOfTheFirstTwo > thirdNum)
            {
                Console.WriteLine(thirdNum);
            }
            else
            {
                Console.WriteLine(smallestOfTheFirstTwo);
            }
        }
        static int GetMin(int a, int b)
        {
            if (a > b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
    }
}
