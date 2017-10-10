using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RemoveElementsAtOddPositions
{
    class RemoveElementsAtOddPositions
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < list.Count; i+= 2)
            {
                list.RemoveAt(i);
                i--;
            }
            Console.WriteLine(string.Join("", list));
        }
    }
}
