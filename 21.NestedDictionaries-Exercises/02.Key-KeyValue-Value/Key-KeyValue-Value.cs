using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Key_KeyValue_Value
{
    class Key_KeyValue_Value
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            string startingKey = Console.ReadLine();
            string startingValue = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " => " }, StringSplitOptions.RemoveEmptyEntries);

                string inputKey = input[0];
                string[] inputValues = input[1].Split(';');

                if (!dict.ContainsKey(inputKey))
                {
                    dict.Add(inputKey, new List<string>());
                }

                foreach (string value in inputValues)
                {
                    dict[inputKey].Add(value);
                }
            }
            foreach (KeyValuePair<string, List<string>> currentData in dict)
            {
                string key = currentData.Key;
                List<string> values = currentData.Value;

                if (key == startingKey || key.Contains(startingKey))
                {
                    Console.WriteLine($"{key}:");

                    foreach (string currentValue in values)
                    {
                        if (currentValue == startingValue || currentValue.Contains(startingValue))
                        {
                            Console.WriteLine($"-{currentValue}");
                        }
                    }
                }
            }
        }
    }
}
