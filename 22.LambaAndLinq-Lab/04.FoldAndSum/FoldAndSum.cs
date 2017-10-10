using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] initial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = initial.Length / 4;

            List<int> left = initial.Take(k).Reverse().ToList();
            List<int> right = initial.Reverse().Take(k).ToList();
            List<int> middle = initial.Skip(k).Take(2 * k).ToList();

            List<int> total = left.Concat(right).ToList();

            for (int i = 0; i < middle.Count; i++)
            {
                middle[i] += total[i];
            }
            Console.WriteLine(string.Join(" ", middle));
        }
    }
}
