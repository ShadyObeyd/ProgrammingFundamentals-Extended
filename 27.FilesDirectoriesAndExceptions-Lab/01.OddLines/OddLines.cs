using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            string[] txt = File.ReadAllLines("Input.txt");

            File.Delete("odd-Input.txt");

            for (int i = 1; i < txt.Length; i+= 2)
            {
                File.AppendAllText("odd-Input.txt", txt[i] + Environment.NewLine);
            }
        }
    }
}
