using System;

class TriangleFormations
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool isValidTriangle = a + b > c && a + c > b && b + c > a;

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");
            bool rightTriangleCondition1 = (a * a) + (b * b) == (c * c);
            bool rightTriangleCondition2 = (b * b) + (c * c) == (a * a);
            bool rightTriangleCondition3 = (a * a) + (c * c) == (b * b);

            if (rightTriangleCondition1)
            {
                Console.WriteLine("Triangle has a right angle between sides a and b");
            }
            else if (rightTriangleCondition2)
            {
                Console.WriteLine("Triangle has a right angle between sides b and c");
            }
            else if (rightTriangleCondition3)
            {
                Console.WriteLine("Triangle has a right angle between sides a and c");
            }
            else
            {
                Console.WriteLine("Triangle has no right angles.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }
    }
}
