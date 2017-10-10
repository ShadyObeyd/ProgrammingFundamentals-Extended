using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class DictRef
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> values = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "end")
            {
                string name = input[0];
                string value = input[1];

                int number;

                if (int.TryParse(value, out number))
                {
                    values[name] = number;
                }
                else
                {
                    if (values.ContainsKey(value))
                    {
                        values[name] = values[value];
                    }
                }

                input = Console.ReadLine().Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (KeyValuePair<string, int> item in values)
            {
                Console.WriteLine($"{item.Key} === {item.Value}");
            }
        }
    }
}
