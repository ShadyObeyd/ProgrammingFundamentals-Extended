using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Shellbound
{
    class Shellbound
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> shells = new Dictionary<string, List<int>>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "Aggregate")
            {
                string town = input[0];
                int shell = int.Parse(input[1]);

                if (!shells.ContainsKey(town))
                {
                    shells.Add(town, new List<int>());
                }

                if (!shells[town].Contains(shell))
                {
                    shells[town].Add(shell);
                }

                input = Console.ReadLine().Split(' ');
            }

            foreach (var shell in shells)
            {
                string town = shell.Key;
                List<int> addedShells = shell.Value;

                int sum = 0;

                for (int i = 0; i < addedShells.Count; i++)
                {
                    sum += addedShells[i];
                }

                Console.WriteLine($"{town} -> {string.Join(", ", addedShells)} ({sum - (sum / addedShells.Count)})");
            }
        }
    }
}
