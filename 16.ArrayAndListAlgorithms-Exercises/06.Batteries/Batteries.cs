using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] ussage = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int hours = int.Parse(Console.ReadLine());
            
            int batteryCntr = 1;
            
            for (int i = 0; i < capacity.Length; i++)
            {
                double remainging = capacity[i] - (ussage[i] * hours);
            
                if (remainging <= 0)
                {
                    double lasted = capacity[i] / ussage[i];
                    Console.WriteLine($"Battery {batteryCntr}: dead (lasted {Math.Ceiling(lasted)} hours)");
                }
                else
                {
                    double percentage = (remainging / capacity[i]) * 100;
                    Console.WriteLine($"Battery {batteryCntr}: {remainging:f2} mAh ({percentage:f2})%");
                }
                batteryCntr++;
            }

        }
    }
}
