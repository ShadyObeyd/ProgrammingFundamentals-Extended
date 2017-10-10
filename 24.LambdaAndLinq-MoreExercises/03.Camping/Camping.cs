using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
    class Camping
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');

                string personName = tokens[0];
                string camperModel = tokens[1];
                int nightsToStay = int.Parse(tokens[2]);

                if (!data.ContainsKey(personName))
                {
                    data.Add(personName, new Dictionary<string, int>());
                }
                data[personName][camperModel] = nightsToStay;

                input = Console.ReadLine();
            }

            var orderedData =
                data
                .OrderByDescending(n => n.Value.Values.Count)
                .ThenBy(n => n.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (KeyValuePair<string, Dictionary<string, int>> details in orderedData)
            {
                
                string personName = details.Key;
                Dictionary<string, int> camperDetails = details.Value;

                Console.WriteLine($"{personName}: {camperDetails.Values.Count}");

                int totalNights = 0;
                foreach (KeyValuePair<string, int> camper in camperDetails)
                {
                    string camperModel = camper.Key;
                    int nightsToStay = camper.Value;

                    totalNights += nightsToStay;
                    
                    Console.WriteLine($"***{camperModel}");
                }
                Console.WriteLine($"Total stay: {totalNights} nights");
            }
        }
    }
}
