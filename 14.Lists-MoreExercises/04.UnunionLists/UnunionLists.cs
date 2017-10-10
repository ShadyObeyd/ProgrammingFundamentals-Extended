using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class UnunionLists
    {
        static void Main(string[] args)
        {
            List<int> primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> inputLists = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                foreach (var number in inputLists)
                {
                    if (!primalList.Contains(number))
                    {
                        primalList.Add(number);
                    }
                    else
                    {
                        primalList.RemoveAll(e => e == number);
                    }
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
