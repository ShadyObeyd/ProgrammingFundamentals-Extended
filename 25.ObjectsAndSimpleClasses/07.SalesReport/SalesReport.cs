using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Sale> sales = new List<Sale>();

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                string town = inputTokens[0];
                string product = inputTokens[1];
                decimal price = decimal.Parse(inputTokens[2]);
                decimal quantity = decimal.Parse(inputTokens[3]);

                Sale sale = new Sale
                {
                    Town = town,
                    Product = product,
                    Price = price,
                    Quantity = quantity
                };
                
                sales.Add(sale);
            }
            List<string> towns =
                sales
                .Select(s => s.Town)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            foreach (string town in towns)
            {
                decimal currentSum =
                    sales
                    .Where(s => s.Town == town)
                    .Select(s => s.Price * s.Quantity)
                    .Sum();

                Console.WriteLine($"{town} -> {currentSum:f2}");
            }
        }
    }
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
    }
}
