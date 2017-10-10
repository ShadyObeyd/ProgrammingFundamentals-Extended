using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main()
        {
            decimal startingCach = decimal.Parse(Console.ReadLine());
            long guestsCount = long.Parse(Console.ReadLine());
            decimal bananaPrice = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            decimal eggsPrice = Math.Round(decimal.Parse(Console.ReadLine()), 2);
            decimal berriesPrice = Math.Round(decimal.Parse(Console.ReadLine()), 2);

            decimal setsOfPortionsNeeded = Math.Ceiling(guestsCount / 6.0m);

            decimal moneyNeeded = (setsOfPortionsNeeded * (2 * bananaPrice)) + (setsOfPortionsNeeded * (4 * eggsPrice)) + (setsOfPortionsNeeded * (0.2m * berriesPrice));
            

            if (startingCach >= moneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {moneyNeeded - startingCach:f2}lv more.");
            }
        }
    }
}
