using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.MagicLetter
{
    class MagicLetter
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char forbiddenChar = char.Parse(Console.ReadLine());

            for (char i = a; i <= b; i++)
            {
                for (char j = a; j <= b; j++)
                {
                    for (char l = a; l <= b; l++)
                    {
                        if (!(i == forbiddenChar || j == forbiddenChar || l == forbiddenChar))
                        {
                            Console.Write($"{i}{j}{l} ");
                        }
                    }
                }
            }
        }
    }
}
