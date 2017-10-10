using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VaporStore
{
    class VaporStore
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            double outFall4Price = 39.99;
            double csOgPrice = 15.99;
            double zplinterZellPrice = 19.99;
            double honored2Price = 59.99;
            double roverWatchPrice = 29.99;
            double roverWatchOriginsPrice = 39.99;

            double totalSpent = 0.0;

            while (money > 0)
            {
                string game = Console.ReadLine().ToLower();
                if (game == "outfall 4")
                {
                    if (money < outFall4Price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= outFall4Price;
                        totalSpent += outFall4Price;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (game == "cs: og")
                {
                    if (money < csOgPrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= csOgPrice;
                        totalSpent += csOgPrice;
                        Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (game == "zplinter zell")
                {
                    if (money < zplinterZellPrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= zplinterZellPrice;
                        totalSpent += zplinterZellPrice;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (game == "honored 2")
                {
                    if (money < honored2Price)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= honored2Price;
                        totalSpent += honored2Price;
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (game == "roverwatch")
                {
                    if (money < roverWatchPrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= roverWatchPrice;
                        totalSpent += roverWatchPrice;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (game == "roverwatch origins edition")
                {
                    if (money < roverWatchOriginsPrice)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        money -= roverWatchOriginsPrice;
                        totalSpent += roverWatchOriginsPrice;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else if (game == "game time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${money:f2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
            if (money <= 0)
            {
                Console.WriteLine("Out of Money!");
            }
        }
    }
}
