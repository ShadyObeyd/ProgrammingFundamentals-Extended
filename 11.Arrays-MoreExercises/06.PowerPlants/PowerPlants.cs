using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PowerPlants
{
    class PowerPlants
    {
        static void Main(string[] args)
        {
            int[] power = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int currentDay = 0;
            int seasonsCntr = 0;
            int daysInSeason = power.Length;

            while (AreAnyPlantsAlive(power))
            {
                for (int i = 0; i < power.Length; i++)
                {
                    if (power[i] != 0)
                    {
                        if ((currentDay % daysInSeason) != i)
                        {
                            power[i]--;
                        }
                    }
                }
                currentDay++;

                if (currentDay % daysInSeason == 0 && AreAnyPlantsAlive(power))
                {
                    for (int i = 0; i < power.Length; i++)
                    {
                        if (power[i] != 0)
                        {
                            power[i]++;
                        }
                    }
                    seasonsCntr++;
                }
            }
            if (seasonsCntr == 1)
            {
                Console.WriteLine($"survived {currentDay} days ({seasonsCntr} season)");
            }
            else
            {
                Console.WriteLine($"survived {currentDay} days ({seasonsCntr} seasons)");
            }
            
        }
        static bool AreAnyPlantsAlive(int[] plantLives)
        {
            for (int i = 0; i < plantLives.Length; i++)
            {
                if (plantLives[i] > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
