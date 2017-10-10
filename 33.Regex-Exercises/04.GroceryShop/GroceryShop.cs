using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.GroceryShop
{
    class GroceryShop
    {
        static void Main()
        {
            Dictionary<string, decimal> data = new Dictionary<string, decimal>();
            Regex pattern = new Regex (@"^(?<product>[A-Z][a-z]+):(?<price>\d+\.?\d{2}?)$");

            string input = Console.ReadLine();

            while (input != "bill")
            {
                Match productData = pattern.Match(input);

                if (productData.Success)
                {
                    string product = productData.Groups["product"].Value;
                    decimal price = decimal.Parse(productData.Groups["price"].Value);

                    if (!data.ContainsKey(product))
                    {
                        data.Add(product, 0);
                    }
                    data[product] = price;
                }

                input = Console.ReadLine();
            }
            data =
                data
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);
            foreach (var productData in data)
            {
                string product = productData.Key;
                decimal price = productData.Value;

                Console.WriteLine($"{product} costs {price}");
            }
        }
    }
}
