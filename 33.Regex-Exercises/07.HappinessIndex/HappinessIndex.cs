using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _07.HappinessIndex
{
    class HappinessIndex
    {
        static void Main()
        {
            Regex happyFaces = new Regex(@"(?<happy>:\)|:D|;\)|:\*|:\]|;\]|:}|;}|\(:|\*:|c:|\[:|\[;)");
            Regex sadFaces = new Regex(@"(?<sad>:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|];)");

            string input = Console.ReadLine();

            MatchCollection happyMatches = happyFaces.Matches(input);
            MatchCollection sadMatches = sadFaces.Matches(input);

            int happyCntr = 0;
            foreach (Match match in happyMatches)
            {
                happyCntr++;
            }
            int sadCntr = 0;
            foreach (Match matches in sadMatches)
            {
                sadCntr++;
            }
            double happynessIndex = (double)happyCntr / (double)sadCntr;
            string icon = "";

            if (happynessIndex >= 2)
            {
                icon = ":D";
            }
            else if (happynessIndex > 1)
            {
                icon = ":)";
            }
            else if (happynessIndex == 1)
            {
                icon = ":|";
            }
            else if (happynessIndex < 1)
            {
                icon = ":(";
            }

            Console.WriteLine($"Happiness index: {happynessIndex:f2} {icon}");
            Console.WriteLine($"[Happy count: {happyCntr}, Sad count: {sadCntr}]");
            
        }
    }
}
