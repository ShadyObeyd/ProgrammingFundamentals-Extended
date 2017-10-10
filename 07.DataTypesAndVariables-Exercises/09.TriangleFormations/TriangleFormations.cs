using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TriangleFormations
{
    class TriangleFormations
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            bool isValid = a + b > c && a + c > b && b + c > a;

            if (isValid)
            {
                Console.WriteLine("Triangle is valid.");
                bool isRightTriangle1 = (a * a) + (b * b) == (c * c);
                bool isRightTriangle2 = (b * b) + (c * c) == (a * a);
                bool isRightTriangle3 = (c * c) + (a * a) == (b * b);
                if (isRightTriangle1)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (isRightTriangle2)
                {
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                }
                else if (isRightTriangle3)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
