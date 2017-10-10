using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main()
        {
            Point firstPoint = ReadPoint(Console.ReadLine());
            Point secondPoint = ReadPoint(Console.ReadLine());

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }
        static Point ReadPoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();

            return new Point(inputData[0], inputData[1]);
        }
        static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);

            return Math.Sqrt(sideA + sideB);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
