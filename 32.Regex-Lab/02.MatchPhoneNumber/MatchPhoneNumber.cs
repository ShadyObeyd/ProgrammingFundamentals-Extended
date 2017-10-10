using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main()
        {
            Regex pattern = new Regex(@"\+359([ -])2\1\d{3}\1\d{4}\b");

            string phoneNumbers = Console.ReadLine();

            MatchCollection matches = pattern.Matches(phoneNumbers);

            List<Match> matchedPhones =
                matches
                .Cast<Match>()
                .ToList();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
