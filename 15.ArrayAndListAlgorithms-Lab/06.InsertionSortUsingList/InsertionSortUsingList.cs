using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.InsertionSortUsingList
{
    class InsertionSortUsingList
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            for (int firstIndex = 0; firstIndex < list.Count; firstIndex++)
            {
                int elementToInsert = list[firstIndex];
                bool hasInserted = false;

                for (int secondIndex = 0; secondIndex < resultList.Count; secondIndex++)
                {
                    if (elementToInsert < resultList[secondIndex])
                    {
                        resultList.Insert(secondIndex, elementToInsert);
                        hasInserted = true;
                        break;
                    }
                }
                if (!hasInserted)
                {
                    resultList.Add(elementToInsert);
                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
