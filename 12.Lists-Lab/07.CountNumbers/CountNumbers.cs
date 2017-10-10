using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();

            int counter = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    counter++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i - 1]} -> {counter}");
                    counter = 1;
                }
            }
            Console.WriteLine($"{numbers[numbers.Count - 1]} -> {counter}");
        }
    }
}
