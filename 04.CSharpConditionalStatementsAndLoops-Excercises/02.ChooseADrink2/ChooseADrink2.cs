using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2
{
    class ChooseADrink2
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine();
            int drinksQuantity = int.Parse(Console.ReadLine());

            if (proffession == "Athlete")
            {
                double drinkPrice = drinksQuantity * 0.7;
                Console.WriteLine($"The {proffession} has to pay {drinkPrice:f2}.");
            }
            else if (proffession == "Businessman" || proffession == "Businesswoman")
            {
                double drinkPrice = drinksQuantity * 1.0;
                Console.WriteLine($"The {proffession} has to pay {drinkPrice:f2}.");
            }
            else if (proffession == "SoftUni Student")
            {
                double drinkPrice = drinksQuantity * 1.7;
                Console.WriteLine($"The {proffession} has to pay {drinkPrice:f2}.");
            }
            else
            {
                double drinkPrice = drinksQuantity * 1.2;
                Console.WriteLine($"The {proffession} has to pay {drinkPrice:f2}.");
            }
        }
    }
}
