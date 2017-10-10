using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RecordUniqueNames
{
    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int namesCntr = int.Parse(Console.ReadLine());

            for (int i = 0; i < namesCntr; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
