using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.BoomingCannon
{
    class BoomingCannon
    {
        static void Main()
        {
            Regex pattern = new Regex(@"(?<=\\<<<)\w+");
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int toSkip = arr[0];
            int elementsToDestroy = arr[1];

            string input = Console.ReadLine();
            
            MatchCollection matches = pattern.Matches(input);

            List<string> destroyed = new List<string>();

            foreach (Match match in matches)
            {
                string destroyedTarget = new string(match.Value.Skip(toSkip).Take(elementsToDestroy).ToArray());

                if (destroyedTarget !="")
                {
                    destroyed.Add(destroyedTarget);
                }
            }
            if (destroyed.Count != 0)
            {
                Console.WriteLine(string.Join("/\\", destroyed));
            }
        }
    }
}
