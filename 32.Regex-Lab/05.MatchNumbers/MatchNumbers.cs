using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.MatchNumbers
{
    class MatchNumbers
    {
        static void Main()
        {
            Regex pattern = new Regex(@">[A-Za-z]+");

            string input = Console.ReadLine();
            List<string> data = new List<string>();

            while (input != "end")
            {
                MatchCollection matches = pattern.Matches(input);
                


                input = Console.ReadLine();
            }

            foreach (string item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
