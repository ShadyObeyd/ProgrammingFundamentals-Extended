using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    class SortArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            List<string> list = new List<string>();

            for (int firstIndex = 0; firstIndex < input.Length; firstIndex++)
            {
                string elementToInsert = input[firstIndex];
                bool isInserted = false;

                for (int secondIndex = 0; secondIndex < list.Count; secondIndex++)
                {
                    if (elementToInsert.CompareTo(list[secondIndex]) < 0)
                    {
                        list.Insert(secondIndex, elementToInsert);
                        isInserted = true;
                        break;
                    }
                }
                if (!isInserted)
                {
                    list.Add(elementToInsert);
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
