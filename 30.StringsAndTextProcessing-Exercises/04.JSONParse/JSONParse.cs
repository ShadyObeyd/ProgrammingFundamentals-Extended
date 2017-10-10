using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JSONParse
{
    class JSONParse
    {
        static void Main()
        {
            string input = Console.ReadLine();

            input = input.Substring(2, input.Length - 2 - 2);
            string[] tokens = input.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokens)
            {
                string[] properties = token.Split(new string[] { "name:\"", ",age:", ",grades:" }, StringSplitOptions.RemoveEmptyEntries);
                string name = properties[0].Replace("\"", "");
                string age = properties[1];
                string grades = properties[2].Replace("[", "").Replace("]", "");

                if (grades == string.Empty)
                {
                    grades = "None";
                }
                Console.WriteLine($"{name} : {age} -> {grades}");
            }
        }
    }
}
