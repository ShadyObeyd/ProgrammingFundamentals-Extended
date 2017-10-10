using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOccurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            string[] wordsInput = Console.ReadLine().ToLower().Split(' ');

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < wordsInput.Length; i++)
            {
                if (!words.Keys.Contains(wordsInput[i]))
                {
                    words.Add(wordsInput[i], 0);
                }
                words[wordsInput[i]]++;
            }

            List<string> result = new List<string>();

            foreach (KeyValuePair<string, int> pair in words)
            {
                if (pair.Value % 2 != 0)
                {
                    result.Add(pair.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
