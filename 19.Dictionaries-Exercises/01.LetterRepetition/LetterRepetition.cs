using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LetterRepetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> charCntr = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charCntr.Keys.Contains(input[i]))
                {
                    charCntr.Add(input[i], 0);
                }
                charCntr[input[i]]++;
            }

            foreach (KeyValuePair<char, int> pair in charCntr)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
