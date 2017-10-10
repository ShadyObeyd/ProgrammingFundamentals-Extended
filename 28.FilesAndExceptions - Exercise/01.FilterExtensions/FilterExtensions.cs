using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.FilterExtensions
{
    class FilterExtensions
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] files = Directory.GetFiles("Input");

            for (int i = 0; i < files.Length; i++)
            {
                if (files[i].EndsWith(input))
                {
                    Console.WriteLine(files[i]);
                }
            }
        }
    }
}
