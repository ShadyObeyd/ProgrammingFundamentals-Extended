using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            int beverageVolume = int.Parse(Console.ReadLine());
            int energyContentPer100g = int.Parse(Console.ReadLine());
            int sugarContentPer100g = int.Parse(Console.ReadLine());

            Console.WriteLine($"{beverageVolume}ml " + beverageName + ":");

            double totalEnergyContent = (beverageVolume / 100.00) * energyContentPer100g;
            double totalSugarContent = (sugarContentPer100g / 100.00) * beverageVolume;

            Console.WriteLine($"{totalEnergyContent}kcal, " + $"{totalSugarContent}g sugars");
        }
    }
}
