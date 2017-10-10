using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.CountOfCapitalLettersInArray
{
    class CountOfCapitalLettersInArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            int cntr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string currentWord = arr[i];

                if (currentWord.Length == 1)
                {
                    char letter = currentWord[0];
                    if (letter >= 'A' && letter <= 'Z')
                    {
                        cntr++;
                    }
                }
            }
            Console.WriteLine(cntr);
        }
    }
}
