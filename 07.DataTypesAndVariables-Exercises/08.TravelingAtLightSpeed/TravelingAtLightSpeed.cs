using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());
            decimal distanceinKm = lightYears * 9450000000000;

            decimal timeInWeeks = distanceinKm / 181440000000;
            Console.WriteLine($"{Math.Floor(timeInWeeks)} weeks");
                                      
            decimal timeInDays = (distanceinKm / 25920000000) % 7;
            Console.WriteLine($"{Math.Floor(timeInDays)} days");

            decimal timeInHours = (distanceinKm / 1080000000) % 24;
            Console.WriteLine($"{Math.Floor(timeInHours)} hours");

            decimal timeInMinutes = (distanceinKm / 18000000) % 60;
            Console.WriteLine($"{Math.Floor(timeInMinutes)} minutes");

            decimal timeInSeconds = (distanceinKm / 300000) % 60;
            Console.WriteLine($"{Math.Floor(timeInSeconds)} seconds");
        }
    }
}
