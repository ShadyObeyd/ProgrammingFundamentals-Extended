using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', '!', '?', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new List<string>();


            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
                string reversedWord = string.Empty;

                for (int j = word.Length - 1; j >= 0; j--)
                {
                    reversedWord += word[j];
                }

                if (word == reversedWord)
                {
                    result.Add(word);
                }
            }
            result = result.Distinct().ToList();
            result.Sort();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
