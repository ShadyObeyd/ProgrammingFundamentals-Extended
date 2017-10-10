using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<text>\D+)(?<count>\d+)");

            string input = Console.ReadLine();
            MatchCollection matches = pattern.Matches(input);
            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                string text = match.Groups["text"].Value;
                int count = int.Parse(match.Groups["count"].Value);

                for (int i = 0; i < count; i++)
                {
                    builder.Append(text.ToUpper());
                }
            }
            int uniqueCount = builder.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueCount}");
            Console.WriteLine(builder.ToString());

        }
    }
}
