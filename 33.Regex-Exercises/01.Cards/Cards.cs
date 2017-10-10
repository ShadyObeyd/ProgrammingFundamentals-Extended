using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Cards
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(^|(?<=[SHDC]))([2-9JQKA]|10)([SHDC])");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);
            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                builder.Append(match + ", ");
            }
            builder = builder.Remove(builder.Length - 2, 2);
            Console.WriteLine(builder);
        }
    }
}
