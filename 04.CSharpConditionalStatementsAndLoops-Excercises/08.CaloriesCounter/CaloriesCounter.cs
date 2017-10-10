using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int ingredientNumber = int.Parse(Console.ReadLine());

            int cheeseCntr = 0;
            int tomatoSauceCntr = 0;
            int salamiCntr = 0;
            int peperCntr = 0;

            for (int i = 0; i < ingredientNumber; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                if (ingredient == "cheese")
                {
                    cheeseCntr += 500;
                }
                else if (ingredient == "tomato sauce")
                {
                    tomatoSauceCntr += 150;
                }
                else if (ingredient == "salami")
                {
                    salamiCntr += 600;
                }
                else if (ingredient == "pepper")
                {
                    peperCntr += 50;
                }
            }
            int totalCalories = cheeseCntr + tomatoSauceCntr + salamiCntr + peperCntr;
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
