using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        secondList.RemoveAt(j);
                        j--;
                    }
                }
            }

            int firstListSum = firstList.Sum();
            int secondListSum = secondList.Sum();

            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {firstListSum}");
            }
            else
            {
                int diff = firstListSum - secondListSum;
                Console.WriteLine($"No. Diff: {Math.Abs(diff)}");
            }
        }
    }
}
