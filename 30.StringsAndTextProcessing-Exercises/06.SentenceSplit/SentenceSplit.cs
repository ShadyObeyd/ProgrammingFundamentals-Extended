using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SentenceSplit
{
    class SentenceSplit
    {
        static void Main()
        {
            string sentence = Console.ReadLine();
            string delimiter = Console.ReadLine();

            string[] text = sentence.Split(new string[] { delimiter }, StringSplitOptions.None);

            Console.WriteLine($"[{string.Join(", ", text)}]");
        }
    }
}
