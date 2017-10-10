using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("text.txt").ToLower().Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (var word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            wordsCount =
                wordsCount
                .OrderByDescending(v => v.Value)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var wordss in wordsCount)
            {
                string word = wordss.Key;
                int count = wordss.Value;

                File.AppendAllText("Output.txt", $"{word} - {count} " + Environment.NewLine);
            }
        }
    }
}
