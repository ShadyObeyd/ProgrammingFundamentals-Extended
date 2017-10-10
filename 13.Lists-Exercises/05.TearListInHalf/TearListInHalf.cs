using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class TearListInHalf
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> firstHalf = GetFirstHalfOfList(list);
            List<int> secondHalf = GetSecondHalfOfList(list);
            
            for (int i = 0; i < secondHalf.Count; i++)
            {
                int lastNumber = secondHalf[i] % 10;
                int firstNumber = (secondHalf[i] / 10) % 10;
                Console.Write($"{firstNumber} {firstHalf[i]} {lastNumber} ");
            }
            Console.WriteLine();
            
        }
        static List<int> GetFirstHalfOfList(List<int> list)
        {
            List<int> firstHalf = new List<int>();

            for (int i = 0; i < list.Count / 2; i++)
            {
                firstHalf.Add(list[i]);
            }

            return firstHalf;
        }
        static List<int> GetSecondHalfOfList(List<int> list)
        {
            List<int> secondHalfList = new List<int>();

            list.Reverse();

            for (int i = list.Count / 2; i > 0; i--)
            {
                secondHalfList.Add(list[i - 1]);
            }

            return secondHalfList;
        }
        
    }
}
