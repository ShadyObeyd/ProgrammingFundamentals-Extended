using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ChooseADrink
{
    class ChooseADrink
    {
        static void Main(string[] args)
        {
            string proffession = Console.ReadLine().ToLower();

            if (proffession == "athlete")
            {
                Console.WriteLine("Water");
            }
            else if (proffession == "businessman" || proffession == "businesswoman")
            {
                Console.WriteLine("Coffee");
            }
            else if (proffession == "softuni student")
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
        }
    }
}
