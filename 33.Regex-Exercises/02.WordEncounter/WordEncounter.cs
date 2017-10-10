using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.WordEncounter
{
    class WordEncounter
    {
        static void Main()
        {
            Regex words = new Regex(@"\w+");
            List<string> validWords = new List<string>();

            string input = Console.ReadLine();

            char filter = input[0];
            int letterCount = int.Parse(input[1].ToString());

            string sentences = Console.ReadLine();

            while (sentences != "end")
            {
                string sentencePattern = @"^[A-Z].*[.?!]$";
                Regex validSentence = new Regex(sentencePattern);

                if (validSentence.IsMatch(sentences))
                {
                    MatchCollection matches = words.Matches(sentences);

                    foreach (Match match in matches)
                    {
                        int cntr = 0;
                        foreach (char @char in match.Value)
                        {
                            if (@char == filter)
                            {
                                cntr++;
                            }
                        }
                        if (cntr >= letterCount)
                        {
                            validWords.Add(match.Value);
                        }
                    }
                }

                sentences = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", validWords));
        }
    }
}
