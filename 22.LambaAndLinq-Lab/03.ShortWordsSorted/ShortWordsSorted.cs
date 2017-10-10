using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
            char[] delimeters = ".,:;()[]\"'\\ /!? ".ToArray();
            string[] words = Console.ReadLine().ToLower().Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            words = words
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
