using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FromTerabytesToBits
{
    class FromTerabytesToBits
    {
        static void Main(string[] args)
        {
            decimal terabytes = decimal.Parse(Console.ReadLine());

            decimal bits = terabytes * 8796093022208;
            Console.WriteLine(Math.Round(bits));
        }
    }
}
