using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_sBack
{
    class CamelsBack
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int camelsBackSize = int.Parse(Console.ReadLine());

            if (list.Count == camelsBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", list)}");
            }
            else
            {
                GetSurvivedBuildings(list, camelsBackSize);
            }
        }
        static void GetSurvivedBuildings(List<int> list, int camelBacksSize)
        {
            int roundsCntr = 0;
            while (list.Count > camelBacksSize)
            {
                list.RemoveAt(0);
                list.RemoveAt(list.Count - 1);
                roundsCntr++;
            }
            Console.WriteLine($"{roundsCntr} rounds");
            Console.WriteLine($"remaining: {string.Join(" ", list)}");
        }
    }
}
