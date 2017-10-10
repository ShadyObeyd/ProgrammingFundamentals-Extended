using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("Input.txt");

            int cntr = 1;
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = $"{cntr}. {text[i]}";
                cntr++;
            }

            File.WriteAllLines("Output.txt", text);
        }
    }
}
