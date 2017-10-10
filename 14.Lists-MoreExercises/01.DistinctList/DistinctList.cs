using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DistinctList
{
    class DistinctList
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> distinctList = list.Distinct().ToList();

            Console.WriteLine(string.Join(" ", distinctList));
        }
    }
}
