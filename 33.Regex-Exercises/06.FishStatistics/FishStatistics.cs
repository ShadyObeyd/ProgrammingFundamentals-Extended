using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.FishStatistics
{
    class FishStatistics
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<tail>>*)<(?<body>\(+)(?<eye>['x-])>");

            string input = Console.ReadLine();

            MatchCollection matches = pattern.Matches(input);
            int cntr = 1;
            foreach (Match match in matches)
            {
                string tail = match.Groups["tail"].Value;
                string tailType = "";
                if (tail.Length > 5)
                {
                    tailType = "Long";
                }
                else if (tail.Length > 1)
                {
                    tailType = "Medium";
                }
                else if (tail.Length == 1)
                {
                    tailType = "Short";
                }
                else
                {
                    tailType = "None";
                }

                string body = match.Groups["body"].Value;
                string bodyType = "";
                if (body.Length > 10)
                {
                    bodyType = "Long";
                }
                else if (body.Length > 5)
                {
                    bodyType = "Medium";
                }
                else
                {
                    bodyType = "Short";
                }

                string eye = match.Groups["eye"].Value;
                string status = "";
                if (eye == "x")
                {
                    status = "Dead";
                }
                else if (eye == "-")
                {
                    status = "Asleep";
                }
                else if (eye == "\'")
                {
                    status = "Awake";
                }

                Console.WriteLine($"Fish {cntr}: {match.Value}");
                if (tail.Length == 0)
                {
                    Console.WriteLine($"Tail type: {tailType}");
                }
                else
                {
                    Console.WriteLine($"Tail type: {tailType} ({tail.Length * 2} cm)");
                }
                Console.WriteLine($"Body type: {bodyType} ({body.Length * 2} cm)");
                Console.WriteLine($"Status: {status}");
                cntr++;
            }

            if (cntr == 1)
            {
                Console.WriteLine("No fish found.");
            }
        }
    }
}
