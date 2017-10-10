using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            int ingredientCntr = 0;
            while (true)
            {
                string ingredient = Console.ReadLine();
                if (ingredient == "Bake!")
                {
                    Console.WriteLine($"Preparing cake with {ingredientCntr} ingredients.");
                    break;
                }
                ingredientCntr++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
        }
    }
}
