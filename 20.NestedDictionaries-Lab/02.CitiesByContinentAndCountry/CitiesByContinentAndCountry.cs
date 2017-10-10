using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CitiesByContinentAndCountry
{
    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, List<string>>>();

            int dataCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < dataCntr; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!data.ContainsKey(continent))
                {
                    data.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent].Add(country, new List<string>());
                }
                data[continent][country].Add(city);
            }

            foreach (KeyValuePair<string, Dictionary<string, List<string>>> item in data)
            {
                string continent = item.Key;
                Dictionary<string, List<string>> contries = item.Value;

                Console.WriteLine($"{continent}:");

                foreach (KeyValuePair<string, List<string>> country in contries)
                {
                    string currentCountry = country.Key;
                    List<string> cities = country.Value; 
                    Console.WriteLine($"  {currentCountry} -> {string.Join(", ", cities)}");
                }
            }
        }
    }
}
