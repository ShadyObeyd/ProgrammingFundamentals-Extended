using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Trainlands
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>(); 
            string input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                string[] tokens = input.Split(new char[] { ' ', '-', '>', '=', ':' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 2)
                {
                    if (input.Contains("="))
                    {
                        string trainName = tokens[0];
                        string trainToCopy = tokens[1];

                        if (!data.ContainsKey(trainName))
                        {
                            data.Add(trainName, new Dictionary<string, long>());
                        }
                        data[trainName].Clear();

                        foreach (var item in data[trainToCopy])
                        {
                            data[trainName].Add(item.Key, item.Value);
                        }
                    }
                    else
                    {
                        string trainToAdd = tokens[0];
                        string trainToDelete = tokens[1];

                        if (!data.ContainsKey(trainToAdd))
                        {
                            data.Add(trainToAdd, new Dictionary<string, long>());
                        }

                        foreach (KeyValuePair<string, long> toDelete in data[trainToDelete])
                        {
                            data[trainToAdd].Add(toDelete.Key, toDelete.Value);
                        }

                        data.Remove(trainToDelete);
                    }
                }
                else
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[1];
                    long wagonPower;

                    if (long.TryParse(tokens[2], out wagonPower))
                    {
                        if (!data.ContainsKey(trainName))
                        {
                            data.Add(trainName, new Dictionary<string, long>());
                        }

                        data[trainName].Add(wagonName, wagonPower);
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var trainData in data.OrderByDescending(v => v.Value.Values.Sum()).ThenBy(k => k.Value.Keys.Count()))
            {
                string trainName = trainData.Key;
                Dictionary<string, long> wagonData = trainData.Value;
            
                Console.WriteLine($"Train: {trainName}");
            
                foreach (KeyValuePair<string, long> wagon in wagonData.OrderByDescending(v => v.Value))
                {
                    string wagonName = wagon.Key;
                    long wagonPower = wagon.Value;
            
                    Console.WriteLine($"###{wagonName} - {wagonPower}");
                }
            }
        }
    }
}
