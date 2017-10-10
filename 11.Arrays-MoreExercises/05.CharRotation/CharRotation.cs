using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharRotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            char[] symbols = Console.ReadLine().ToCharArray();
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[i] % 2 == 0)
                {
                    symbols[i] -= (char)integers[i];
                }
                else
                {
                    symbols[i] += (char)integers[i];
                }
                Console.Write(symbols[i]);
            }
            Console.WriteLine();
            
        }
    }
}
