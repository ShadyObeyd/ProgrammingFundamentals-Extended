using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.TrickyStrings
{
    class TrickyStrings
    {
        static void Main(string[] args)
        {
            string delimeter = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string totalString = string.Empty;

            for (int i = 0; i < n - 1; i++)
            {
                string input = Console.ReadLine();
                totalString += input + delimeter;
            }
            string finalInput = Console.ReadLine();
            Console.WriteLine(totalString + finalInput);
        }
    }
}
