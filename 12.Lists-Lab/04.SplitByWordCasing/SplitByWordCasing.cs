using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class SplitByWordCasing
    {
        static void Main(string[] args)
        {
            char[] separators = ",;:.!( )\"'\\/[ ] ".ToCharArray();
            string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            List<string> uppercase = new List<string>();
            List<string> lowercase = new List<string>();
            List<string> mixedcase = new List<string>();

            foreach (string word in input)
            {
                bool isUpper = false;
                bool isLower = false;
                bool isSymbol = false;

                foreach (char letter in word)
                {
                    if (char.IsUpper(letter))
                    {
                        isUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        isLower = true;
                    }
                    else if (!char.IsLetter(letter))
                    {
                        isSymbol = true;
                    }
                }
                if (isSymbol)
                {
                    mixedcase.Add(word);
                }
                else if (!isUpper)
                {
                    lowercase.Add(word);
                }
                else if (!isLower)
                {
                    uppercase.Add(word);
                }
                else
                {
                    mixedcase.Add(word);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ", lowercase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedcase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercase)}");
        }
    }
}
