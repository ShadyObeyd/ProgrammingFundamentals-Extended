using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matches = pattern.Matches(names);

            foreach (Match match in matches)
            {
                Console.Write(match + " ");
            }
            Console.WriteLine();
        }
    }
}
