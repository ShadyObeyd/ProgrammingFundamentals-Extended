using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Placeholders
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                
                string text = tokens[0];
                string[] values = tokens[1].Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < values.Length; i++)
                {
                    string value = values[i];
                    string toReplace = "{" + i + "}";

                    text = text.Replace(toReplace, value);
                }
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
        }
    }
}
