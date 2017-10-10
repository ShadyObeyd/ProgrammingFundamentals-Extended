using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TravelCompany
{
    class TravelCompany
    {
        static void Main(string[] args)
        {
            var totalOffers = new Dictionary<string, Dictionary<string, int>>();

            string[] tokens = Console.ReadLine().Split(':');

            while (tokens[0] != "ready")
            {
                string city = tokens[0];
                string[] vechicles = tokens[1].Split(new char[] { ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

                if (!totalOffers.ContainsKey(city))
                {
                    totalOffers.Add(city, new Dictionary<string, int>());
                }

                for (int i = 0; i < vechicles.Length - 1; i += 2)
                {
                    string vechcile = vechicles[i];
                    int capacity = int.Parse(vechicles[i + 1]);

                    if (!totalOffers[city].ContainsKey(vechcile))
                    {
                        totalOffers[city].Add(vechcile, capacity);
                    }
                    else
                    {
                        totalOffers[city][vechcile] = capacity;
                    }
                }

                tokens = Console.ReadLine().Split(':');
            }
            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "travel")
            {
                string city = input[0];
                int peopleCnt = int.Parse(input[1]);

                foreach (var offer in totalOffers)
                {
                    string town = offer.Key;
                    var vechicleAndCapacity = offer.Value;
                    int sum = 0;

                    if (city == town)
                    {
                        foreach (var item in vechicleAndCapacity)
                        {
                            sum += item.Value;
                        }

                        if (sum >= peopleCnt)
                        {
                            Console.WriteLine($"{city} -> all {peopleCnt} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{city} -> all except {peopleCnt - sum} accommodated");
                        }
                    }

                }
                input = Console.ReadLine().Split(' ');
            }
        }
    }
}
