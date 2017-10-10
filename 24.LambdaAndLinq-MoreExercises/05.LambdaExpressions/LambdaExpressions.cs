using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LambdaExpressions
{
    class LambdaExpressions
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> data = new Dictionary<string, Dictionary<string, string>>();

            string input = Console.ReadLine();

            while (input != "lambada")
            {
                string[] tokens = input.Split(new char[] { ' ', '.', '=', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (input == "dance")
                {
                    data = data
                        .ToDictionary(s => s.Key,
                                      s => s.Value
                                      .ToDictionary(r => r.Key,
                                                    v => v.Key + "." + v.Value));
                }
                else
                {
                    string selector = tokens[0];
                    string selectorObject = tokens[1];
                    string property = tokens[2];
                
                    if (!data.ContainsKey(selector))
                    {
                        data.Add(selector, new Dictionary<string, string>());
                    }
                    data[selector][selectorObject] = property;
                }

                input = Console.ReadLine();
            }

            foreach (var datas in data)
            {
                string selector = datas.Key;
                Dictionary<string, string> values = datas.Value;
            
                foreach (var item in values)
                {
                    Console.WriteLine($"{selector} => {item.Key}.{item.Value}");
                }
            }
        }
    }
}
