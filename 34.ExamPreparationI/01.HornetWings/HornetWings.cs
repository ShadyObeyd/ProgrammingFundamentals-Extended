using System;


namespace _01.HornetWings
{
    class HornetWings
    {
        static void Main()
        {
            long wingFlapes = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double traveledDistance = (wingFlapes / 1000.00) * distance;

            Console.WriteLine($"{traveledDistance:f2} m.");

            long rested = ((wingFlapes / endurance) * 5) + (wingFlapes / 100);

            Console.WriteLine($"{rested} s.");
        }
    }
}
