using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Trainers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double technical = 0;
            double theoretical = 0;
            double practical = 0;

            for (int i = 0; i < n; i++)
            {
                long distanceToTravel = long.Parse(Console.ReadLine())* 1600;
                double cargoWeight = double.Parse(Console.ReadLine()) * 1000;
                string teamName = Console.ReadLine().ToLower();

                double fuelexpenses = distanceToTravel * 0.7 * 2.5;
                double cargoIncome = 1.5 * cargoWeight;
                double total = cargoIncome - fuelexpenses;

                if (teamName == "technical")
                {
                    technical += total;
                }
                else if (teamName == "theoretical")
                {
                    theoretical += total;
                }
                else if (teamName == "practical")
                {
                    practical += total;
                }
            }

            if (technical > theoretical && technical > practical)
            {
                Console.WriteLine($"The Technical Trainers win with ${technical:f3}.");
            }
            else if (theoretical > technical && theoretical > practical)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${theoretical:f3}.");
            }
            else if (practical > technical && practical > theoretical)
            {
                Console.WriteLine($"The Practical Trainers win with ${practical:f3}.");
            }
        }
    }
}
