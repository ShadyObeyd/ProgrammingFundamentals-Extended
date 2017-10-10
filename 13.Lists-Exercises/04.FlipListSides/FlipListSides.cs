using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class FlipListSides
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int i = 1; i < list.Count - 1; i++)
            {
                resultList.Add(list[i]);
            }
            resultList.Reverse();

            Console.Write(list[0] + " ");
            Console.Write(string.Join(" " ,resultList));
            Console.WriteLine(" " + list.Last());
        }
    }
}
