using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringDecryption
{
    class StringDecryption
    {
        static void Main()
        {
            int[] inputTokens = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int elementsToSkip = inputTokens[0];
            int elementsToTake = inputTokens[1];

            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            arr =
               arr
               .Where(n => n >= 65 && n <= 90)
               .Skip(elementsToSkip)
               .Take(elementsToTake)
               .ToArray();

            string result = "";

            for (int i = 0; i < arr.Length; i++)
            {
                char letter = (char)arr[i];
                result += letter;
            }

            Console.WriteLine(result);
        }
    }
}
