using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DiamondProblem
{
    class DiamondProblem
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int leftIndex = -1;
            int rightIndex = -1;
            bool isDiamond = false;
            while ((leftIndex = input.IndexOf('<', leftIndex + 1)) > -1 && (rightIndex = input.IndexOf('>', leftIndex +1)) > -1)
            {
                string diamondContent = input.Substring(leftIndex + 1, rightIndex - leftIndex - 1);

                int sum = 0;
                foreach (char @char in diamondContent)
                {
                    if (char.IsDigit(@char))
                    {
                        sum += int.Parse(@char.ToString());
                    }
                }
                isDiamond = true;
                Console.WriteLine($"Found {sum} carat diamond");
            }
            if (!isDiamond)
            {
                Console.WriteLine("Better luck next time");
            }
        }
    }
}
