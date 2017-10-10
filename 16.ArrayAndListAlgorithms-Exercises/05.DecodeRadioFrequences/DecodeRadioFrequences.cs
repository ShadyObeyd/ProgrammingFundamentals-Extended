using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DecodeRadioFrequences
{
    class DecodeRadioFrequences
    {
        static void Main(string[] args)
        {
            string[] frequences = Console.ReadLine().Split(' ');

            List<char> result = new List<char>();

            for (int i = 0; i < frequences.Length; i++)
            {
                string[] tokens = frequences[i].Split('.');
                int leftPart = int.Parse(tokens[0]);
                int rightPart = int.Parse(tokens[1]);

                char start = (char)leftPart;
                char end = (char)rightPart;

                if (leftPart != 0)
                {
                    result.Insert(i, start);
                }

                if (rightPart != 0)
                {
                    result.Insert(result.Count - 1 - i, end);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}
