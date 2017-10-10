using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int comboCntr = 0;
            int firstNum = 0;
            int secondNum = 0;

            for (int i = min; i <= max; i++)
            {
                for (int j = min; j <= max; j++)
                {
                    if (i + j == magicNum)
                    {
                        firstNum = i;
                        secondNum = j;
                    }
                    comboCntr++;
                }
            }
            if (firstNum + secondNum == magicNum)
            {
                Console.WriteLine($"Number found! {firstNum} + {secondNum} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{comboCntr} combinations - neither equals {magicNum}");
            }
            
        }
    }
}
