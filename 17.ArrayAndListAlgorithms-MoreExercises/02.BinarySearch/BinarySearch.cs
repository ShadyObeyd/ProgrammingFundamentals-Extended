using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int numToFind = int.Parse(Console.ReadLine());

            LinearSearch(numbers, numToFind);
            BinarySearch1(numbers, numToFind);

        }
        static void LinearSearch(List<int> list, int num)
        {
            int iterationsCntr = 0;
            int currentNum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                currentNum = list[i];
                iterationsCntr++;
                if (currentNum == num)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine($"Linear search made {iterationsCntr} iterations");
                    break;
                }
            }
            if (currentNum != num)
            {
                Console.WriteLine("No");
                Console.WriteLine($"Linear search made {iterationsCntr} iterations");
            }
        }
        static void BinarySearch1(List<int> list, int num)
        {
            List<int> copy = list;
            copy.Sort();

            int startPoint = 0;
            int endPoint = copy.Count - 1;
            int iterationsCntr = 0;
            int currentNum = 0;

            while (startPoint <= endPoint)
            {
                int midPoint = (startPoint + endPoint) / 2;
                iterationsCntr++;
                currentNum = copy[midPoint];
                if (currentNum < num)
                {
                    startPoint = midPoint + 1;
                }

                if (currentNum > num)
                {
                    endPoint = midPoint - 1;
                }

                if (currentNum == num)
                {
                    Console.WriteLine($"Binary search made {iterationsCntr} iterations");
                    break;
                }
            }
            if (currentNum != num)
            {
                Console.WriteLine($"Binary search made {iterationsCntr} iterations");
            }
        }
    }
}
