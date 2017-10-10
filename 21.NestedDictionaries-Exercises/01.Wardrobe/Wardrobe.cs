using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Wardrobe
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string colour = items[0];
                string[] clothes = items[1].Split(',');

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe.Add(colour, new Dictionary<string, int>());
                }

                foreach (string cloth in clothes)
                {
                    if (!wardrobe[colour].ContainsKey(cloth))
                    {
                        wardrobe[colour].Add(cloth, 0);
                    }
                    wardrobe[colour][cloth]++;
                }
            }

            string[] input = Console.ReadLine().Split(' ');

            foreach (var clothes in wardrobe)
            {
                string colour = clothes.Key;
                Dictionary<string, int> cloth = clothes.Value;

                Console.WriteLine($"{colour} clothes:");

                foreach (var item in cloth)
                {
                    string result = $"* {item.Key} - {item.Value}";

                    if (input[0] == colour && input[1] == item.Key)
                    {
                        result +=  " (found!)";
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
