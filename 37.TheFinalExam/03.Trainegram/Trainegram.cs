using System;
using System.Text.RegularExpressions;

namespace _03.Trainegram
{
    class Trainegram
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^(<\[[^A-Za-z0-9]*]\.)(\.\[[A-Za-z0-9]*]\.)*$");
            string input = Console.ReadLine();

            while (input != "Traincode!")
            {
                MatchCollection matches = pattern.Matches(input);

                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
