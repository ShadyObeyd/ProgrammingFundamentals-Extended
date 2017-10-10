using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.AsciiString
{
    class AsciiString
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string totalString = string.Empty;
            
            for (int i = 0; i < n; i++)
            {
                int letters = int.Parse(Console.ReadLine());

                char realLetters = Convert.ToChar(letters);
                totalString += realLetters;
            }
            Console.WriteLine(totalString);
        }
    }
}
