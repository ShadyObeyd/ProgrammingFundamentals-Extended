using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MostValuedCustomer
{
    class MostValuedCustomer
    {
        static void Main()
        {
            Dictionary<string, double> productsData = new Dictionary<string, double>();
            Dictionary<string, List<string>> customersData = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] tokens = input.Split(' ');
                string product = tokens[0];
                double price = double.Parse(tokens[1]);

                productsData[product] = price;

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Print")
            {
                if (input == "Discount")
                {
                    var discountedProducts =
                        productsData
                        .OrderByDescending(r => r.Value)
                        .Take(3)
                        .Select(pd => new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));

                    foreach (var discountedProduct in discountedProducts)
                    {
                        productsData[discountedProduct.Key] = discountedProduct.Value;
                    }
                }
                else
                {
                    string[] tokens = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                    string customerName = tokens[0];
                    string[] productsBought = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                    if (!customersData.ContainsKey(customerName))
                    {
                        customersData.Add(customerName, new List<string>());
                    }

                    for (int i = 0; i < productsBought.Length; i++)
                    {
                        string productBought = productsBought[i];

                        if (productsData.ContainsKey(productBought))
                        {
                            customersData[customerName].Add(productBought);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            var topCustomer =
                customersData
                .OrderByDescending(d => d.Value.Sum(p => productsData[p]))
                .First();

            string name = topCustomer.Key;
            List<string> productssBought = topCustomer.Value;

            Console.WriteLine($"Biggest spender: {name}");
            Console.WriteLine("^Products bought:");

            double total = productssBought.Sum(p => productsData[p]);

            var orderedProducts = productssBought.Distinct().OrderByDescending(p => productsData[p]);

            foreach (var product in orderedProducts)
            {
                Console.WriteLine($"^^^{product}: {productsData[product]:f2}");
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
