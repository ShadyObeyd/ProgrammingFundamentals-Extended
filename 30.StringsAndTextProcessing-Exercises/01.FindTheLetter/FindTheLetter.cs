using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FindTheLetter
{
    class FindTheLetter
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string[] inputTokens = Console.ReadLine().Split(' ');

            char letterToSearchFor = char.Parse(inputTokens[0]);
            int occurenceToFind = int.Parse(inputTokens[1]);

            int index = -1;

            do
            {
                occurenceToFind--;
                index = inputString.IndexOf(letterToSearchFor, index + 1);
            } while (index != -1 && occurenceToFind > 0);

            if (index != -1)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("Find the letter yourself!");
            }
        }
    }
}
