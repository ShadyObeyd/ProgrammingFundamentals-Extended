using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Entertrain
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            int locomotivePower = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int numToAdd = int.Parse(input);
                numbers.Add(numToAdd);
                int average = numbers.Sum() / numbers.Count();
                if (numbers.Sum() > locomotivePower)
                {
                    int closest = numbers.OrderBy(n => Math.Abs(average - n)).First();

                    numbers.Remove(closest);
                }

                input = Console.ReadLine();
            }
            numbers.Reverse();
            numbers.Add(locomotivePower);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
