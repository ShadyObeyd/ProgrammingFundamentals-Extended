using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class ExamShopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> merchandise = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "shopping")
            {
                string item = input[1];
                int quantity = int.Parse(input[2]);

                if (!merchandise.ContainsKey(item))
                {
                    merchandise[item] = 0; 
                }
                merchandise[item] += quantity;

                input = Console.ReadLine().Split(' ');
            }

            input = Console.ReadLine().Split(' ');

            while (input[0] != "exam")
            {
                string item = input[1];
                int quantity = int.Parse(input[2]);

                if (!merchandise.ContainsKey(item))
                {
                    Console.WriteLine($"{item} doesn't exist");
                }
                else if (merchandise[item] <= 0)
                {
                    Console.WriteLine($"{item} out of stock");
                }
                else
                {
                    merchandise[item] -= quantity;
                }
                input = Console.ReadLine().Split(' ');
            }

            foreach (KeyValuePair<string, int> product in merchandise)
            {
                if (product.Value > 0)
                {
                    Console.WriteLine($"{product.Key} -> {product.Value}");
                }
            }
        }
    }
}
