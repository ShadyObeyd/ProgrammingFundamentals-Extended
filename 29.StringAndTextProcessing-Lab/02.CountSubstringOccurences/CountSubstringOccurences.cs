using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurences
{
    class CountSubstringOccurences
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string stringToCheck = Console.ReadLine().ToLower();

            int cntr = 0;
            int index = text.IndexOf(stringToCheck);

            while (index != -1)
            {
                cntr++;
                index = text.IndexOf(stringToCheck, index + 1);
            }

            Console.WriteLine(cntr);
        }
    }
}
