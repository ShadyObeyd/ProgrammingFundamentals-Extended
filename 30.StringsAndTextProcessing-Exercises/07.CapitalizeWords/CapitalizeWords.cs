using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CapitalizeWords
{
    class CapitalizeWords
    {
        static void Main()
        {
            char[] splitBy = { '.', ',', ' ', '!', '?', '/', '\\', '%', '$', '#', '*', '@', '+', '-', ':', ';', '[', ']', '|', '\"', '^', '(', ')', '&', };

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(splitBy, StringSplitOptions.RemoveEmptyEntries);
                

                for (int i = 0; i < tokens.Length; i++)
                {
                    tokens[i] = Capitalize(tokens[i]);
                }

                Console.WriteLine(string.Join(", ", tokens));

                input = Console.ReadLine();
            }
        }
        static string Capitalize(string input)
        {
            StringBuilder builder = new StringBuilder(input);

            builder[0] = char.ToUpper(builder[0]);

            for (int i = 1; i < builder.Length; i++)
            {
                builder[i] = char.ToLower(builder[i]);
            }
            return builder.ToString();
        }
    }
}
