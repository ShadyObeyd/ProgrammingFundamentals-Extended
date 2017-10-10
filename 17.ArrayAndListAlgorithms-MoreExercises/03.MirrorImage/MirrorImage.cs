using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MirrorImage
{
    class MirrorImage
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            string n = Console.ReadLine();

            while (n != "Print")
            {
                int index = int.Parse(n);

                for (int i = 0; i < index / 2; i++)
                {
                    string temp = list[i];
                    list[i] = list[index - i - 1];
                    list[index - i - 1] = temp;
                }
                n = Console.ReadLine();
                list.Reverse();

                for (int i = 0; i < (list.Count - 1 - index) / 2; i++)
                {
                    string temp = list[i];
                    list[i] = list[list.Count - 2 - index - i];
                    list[list.Count - 2 - index - i] = temp;
                }
                list.Reverse();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
