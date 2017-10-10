using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TextFilter
{
    class TextFilter
    {
        static void Main()
        {
            string[] banned = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            for (int i = 0; i < banned.Length; i++)
            {
                string bannedWord = banned[i];

                text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                
            }
            Console.WriteLine(text);
        }
    }
}
