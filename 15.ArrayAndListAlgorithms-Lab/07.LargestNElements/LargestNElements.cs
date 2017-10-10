using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestNElements
{
    class LargestNElements
    {
        static List<int> list;
        static void Main(string[] args)
        {
            list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ReverseList()[i]} ");
            }
            Console.WriteLine();

        }
        static List<int> ReverseList()
        {

            List<int> reversedList = SortList();

            int left = 0;
            int right = reversedList.Count - 1;
        
            while (left < reversedList.Count / 2)
            {
                int temp = reversedList[left];
                reversedList[left] = SortList()[right];
                reversedList[right] = temp;
        
                left++;
                right--;
            }

            return reversedList;
        }
        static List<int> SortList()
        {
            List<int> sortedList = new List<int>();

            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                int elementToInsert = list[firstIndex];
                bool isInserted = false;

                for (int secondIndex = 0; secondIndex < sortedList.Count; secondIndex++)
                {
                    if (elementToInsert < sortedList[secondIndex])
                    {
                        sortedList.Insert(secondIndex, elementToInsert);
                        isInserted = true;
                        break;
                    }
                }
                if (!isInserted)
                {
                    sortedList.Add(elementToInsert);
                }
            }

            return sortedList;
        }
    }
}
