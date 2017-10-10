using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.StringEncryption
{
    class StringEncryption
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string totalResult = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int lastDigit = letter % 10;
                int firstResult = letter + lastDigit;
                int firstDigit = 0;


                if (letter >= 10 && letter < 100)
                {
                    firstDigit = letter / 10;
                }
                else if (letter >= 100)
                {
                    firstDigit = letter / 100;
                }
                int secondResult = letter - firstDigit;

                string result = "" + (char)firstResult + firstDigit + lastDigit + (char)secondResult;
                totalResult += result;
            }
            Console.WriteLine(totalResult);
        }
    }
}
