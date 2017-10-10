using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHall
{
    class TrainingHall
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double initialBudget = budget;
            int itemNumber = int.Parse(Console.ReadLine());
            double subtotal = 0.0;
            for (int i = 0; i < itemNumber; i++)
            {
                string itemName = Console.ReadLine().ToLower();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                {
                    itemName += "s";
                }
                subtotal += itemCount * itemPrice;
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
            }
            budget -= subtotal;
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if (subtotal > initialBudget)
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget:f2}");
            }
            
            
        }
    }
}
