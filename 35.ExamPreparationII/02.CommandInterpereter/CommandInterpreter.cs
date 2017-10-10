using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CommandInterpereter
{
    class CommandInterpreter
    {
        static List<string> input = Console.ReadLine().Split(' ').ToList();
        static void Main()
        {
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] tokens = commands.Split(' ');
                int start = 0;
                int count = 0;

                switch (tokens[0])
                {
                    case "reverse":
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);

                        if (isValid(start, count))
                        {
                            input.Reverse(start, count);
                        }
                        break;
                    case "sort":
                        start = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                        SortInput(start, count);
                        
                        break;
                    case "rollLeft":
                        count = int.Parse(tokens[1]);
                        RollLeft(count);
                        break;
                    case "rollRight":
                        count = int.Parse(tokens[1]);
                        RollRight(count);
                        break;
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static void RollRight(int count)
        {
            if (count >= 0)
            {
                for (int i = 0; i < count % input.Count; i++)
                {
                    string last = input[input.Count - 1];

                    for (int j = input.Count - 1; j > 0; j--)
                    {
                        input[j] = input[j - 1];
                    }
                    input[0] = last;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void RollLeft(int count)
        {
            if (count >= 0)
            {
                for (int i = 0; i < count % input.Count; i++)
                {
                    string first = input[0];

                    for (int j = 0; j < input.Count - 1; j++)
                    {
                        input[j] = input[j + 1];
                    }
                    input[input.Count - 1] = first;
                }
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }
        }

        private static void SortInput(int start, int count)
        {
            if (isValid(start, count))
            {
                List<string> temp = input.Skip(start).Take(count).ToList();
                temp.Sort();
                input.RemoveRange(start, count);
                input.InsertRange(start, temp);
            }
            
        }

        private static bool isValid(int start, int count)
        {
            bool isInrange = start >= 0 && start < input.Count;
            bool isValidCount = (start + count) <= input.Count && count >= 0;

            if (isInrange && isValidCount)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return false;
            }
        }
    }
}
