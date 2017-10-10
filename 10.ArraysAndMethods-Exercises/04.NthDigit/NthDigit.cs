using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NthDigit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int inputIndex = int.Parse(Console.ReadLine());

            
            Console.WriteLine(FindDigit(inputNum, inputIndex));
        }
        static int FindDigit(int num, int index)
        {
            int indexCntr = 1;
            while (num > 0)
            {
                if (indexCntr == index)
                {
                    num %= 10;
                    break;
                }
                else
                {
                    num /= 10;
                }
                indexCntr++;
            }
            return num;
        }
    }
}
