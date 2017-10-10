using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
    class CottageScraper
    {
        static void Main()
        {
            List<KeyValuePair<string, int>> data = new List<KeyValuePair<string, int>>();

            string input = Console.ReadLine().ToLower();
            double avarage = 0.0;
            while (input != "chop chop")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string treeType = tokens[0];
                int height = int.Parse(tokens[1]);

                data.Add(new KeyValuePair<string, int>(treeType, height));

                

                input = Console.ReadLine().ToLower();
            }
            string treeWanted = Console.ReadLine().ToLower();
            int minHeight = int.Parse(Console.ReadLine());
            
            avarage = Math.Round(data.Average(r => r.Value), 2);
            Console.WriteLine($"Price per meter: ${avarage:f2}");
          
           var usedLogs =
               data
               .Where(k => k.Key == treeWanted)
               .Where(r => r.Value >= minHeight);
          
           double usedLogsPrice = Math.Round(usedLogs.Sum(r => r.Value * avarage), 2);
           Console.WriteLine($"Used logs price: ${usedLogsPrice:f2}");

            double unusedLogsPrice = 0.0;

            foreach (var item in data)
            {
                if (item.Key != treeWanted || item.Value < minHeight)
                {
                    unusedLogsPrice = Math.Round((unusedLogsPrice + item.Value), 2);
                }
            }
            unusedLogsPrice = Math.Round((unusedLogsPrice * avarage * 0.25), 2);
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:f2}");

            double totalPrice = Math.Round((usedLogsPrice + unusedLogsPrice), 2);
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
}
