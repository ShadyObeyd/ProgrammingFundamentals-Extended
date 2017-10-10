using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CypherRoulette
{
    class CypherRoulette
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isReversed = false;
            string output = string.Empty;
            string previousString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string currentString = Console.ReadLine();
                if (currentString == previousString)
                {
                    output = string.Empty;
                    if (currentString == "spin")
                    {
                        i--;
                    }
                }
                else
                {
                    if (currentString == "spin")
                    {
                        isReversed = !isReversed;
                        i--;
                    }
                    else
                    {
                        if (isReversed)
                        {
                            output = currentString + output;
                        }
                        else
                        {
                            output += currentString;
                        }
                    }
                }
                previousString = currentString;
            }
            Console.WriteLine(output);
        }
    }
}
