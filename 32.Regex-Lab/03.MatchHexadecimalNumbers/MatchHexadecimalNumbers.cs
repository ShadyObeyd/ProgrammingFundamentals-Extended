using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b(0x)?[0-9A-F]+\b");

            string numbers = Console.ReadLine();

            MatchCollection matches = pattern.Matches(numbers);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
