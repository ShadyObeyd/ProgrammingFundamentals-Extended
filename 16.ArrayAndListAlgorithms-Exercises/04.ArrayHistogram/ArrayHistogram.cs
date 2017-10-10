using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class ArrayHistogram
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            List<string> words = new List<string>();
            List<int> count = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {

                if (!words.Contains(arr[i]))
                {
                    words.Add(arr[i]);
                    count.Add(1);
                }
                else
                {
                    int index = words.IndexOf(arr[i]);
                    count[index]++;
                }
            }

            for (int i = 0; i < count.Count - 1; i++)
            {
                int index = i + 1;

                while (index > 0)
                {
                    if (count[index - 1] < count[index])
                    {
                        int tempCount = count[index];
                        count[index] = count[index - 1];
                        count[index - 1] = tempCount;

                        string tempWord = words[index];
                        words[index] = words[index - 1];
                        words[index - 1] = tempWord;
                    }
                    index--;
                }
            }
            for (int i = 0; i < count.Count; i++)
            {
                Console.WriteLine($"{words[i]} -> {count[i]} times ({((double)count[i] / (double)arr.Length) * 100:f2}%)");
            }
        }
    }
}
