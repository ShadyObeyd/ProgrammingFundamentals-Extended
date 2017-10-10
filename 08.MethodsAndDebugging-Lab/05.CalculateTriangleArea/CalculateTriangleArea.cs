using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());

            double area = PrintArea(triangleBase, triangleHeight);
            Console.WriteLine(area);
        }
        static double PrintArea(double Base, double height)
        {
            return (Base * height) / 2;
        }
    }
}
