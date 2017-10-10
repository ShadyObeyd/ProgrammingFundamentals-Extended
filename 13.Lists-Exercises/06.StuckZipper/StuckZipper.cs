using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StuckZipper
{
    class StuckZipper
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int minLenght = GetSmallestAmountOfDigits(firstList, secondList);

            List<int> firstFilteredList = new List<int>();
            List<int> secondFilteredList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                if (FindNumberLenght(firstList[i]) <= minLenght)
                {
                    firstFilteredList.Add(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (FindNumberLenght(secondList[i]) <= minLenght)
                {
                    secondFilteredList.Add(secondList[i]);
                }
            }

            List<int> resultList = new List<int>();

            for (int i = 0; i < Math.Max(firstFilteredList.Count, secondFilteredList.Count); i++)
            {
                if (i < secondFilteredList.Count)
                {
                    resultList.Add(secondFilteredList[i]);
                }
                if (i < firstFilteredList.Count)
                {
                    resultList.Add(firstFilteredList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", resultList));
            
        }
        static int GetSmallestAmountOfDigits(List<int> firstList, List<int> secondList)
        {
            int smallestAmmountOfDigits = int.MaxValue;

            for (int i = 0; i < firstList.Count; i++)
            {
                if (smallestAmmountOfDigits > FindNumberLenght(firstList[i]))
                {
                    smallestAmmountOfDigits = FindNumberLenght(firstList[i]);
                }
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (smallestAmmountOfDigits > FindNumberLenght(secondList[i]))
                {
                    smallestAmmountOfDigits = FindNumberLenght(secondList[i]);
                }
            }

            return smallestAmmountOfDigits;
        }
        private static int FindNumberLenght(int number)
        {
            int newNumber = Math.Abs(number);
            int numOfDigits = 0;

            while (newNumber > 0)
            {
                numOfDigits++;
                newNumber /= 10;
            }
            return numOfDigits;
        }
    }
}
