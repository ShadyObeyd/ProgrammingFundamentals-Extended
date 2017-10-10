using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AvarageCharacterDelimeter
{
    class AvarageCharacterDelimeter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int sum = 0;
            int lettersCount = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];

                for (int j = 0; j < word.Length; j++)
                {
                    sum += word[j];
                    lettersCount++;
                }
            }
            char delimeter = (char)(sum / lettersCount);
            string UpperDelimeter = delimeter.ToString().ToUpper();

            Console.WriteLine(string.Join(UpperDelimeter, input));
        }
    }
}
