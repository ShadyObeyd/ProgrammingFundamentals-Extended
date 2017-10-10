using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ForumTopics
{
    class ForumTopics
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forums = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "filter")
            {
                string topic = input[0];
                string[] tags = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!forums.ContainsKey(topic))
                {
                    forums.Add(topic, new List<string>());
                }

                for (int i = 0; i < tags.Length; i++)
                {
                    string tag = tags[i];
                    forums[topic].Add(tag);
                }
                input = Console.ReadLine().Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
            }

            string[] inputLine = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var forum in forums)
            {
                string topic = forum.Key;
                List<string> tags = forum.Value;
                tags = tags.Distinct().ToList();
                bool isContained = true;
                for (int i = 0; i < inputLine.Length; i++)
                {
                    if (!tags.Contains(inputLine[i]))
                    {
                        isContained = false;
                        break;
                    }
                }
                if (isContained)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                }
            }
        }
    }
}
