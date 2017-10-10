using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> resultNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    resultNumbers.Add(numbers[i]);
                }
            }
            resultNumbers.Sort();
            resultNumbers.Reverse();

            Console.WriteLine(string.Join(" ", resultNumbers));
        }
    }
}
