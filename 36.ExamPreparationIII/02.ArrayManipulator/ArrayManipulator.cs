using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayManipulator
{
    class ArrayManipulator
    {
        static List<int> input;
        static void Main()
        {
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split(' ');
                bool isOdd = false;
                int count = 0;
                List<int> result = new List<int>();
                switch (tokens[0])
                {
                    case "exchange":
                        int index = int.Parse(tokens[1]);

                        if (index >= 0 && index < input.Count)
                        {
                            input = Exhange(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "max":
                        isOdd = ParseOdd(tokens[1]);
                        int maxIndex = Max(isOdd);
                        if (maxIndex >= 0)
                        {
                            Console.WriteLine(maxIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "min":
                        isOdd = ParseOdd(tokens[1]);
                        int minIndex = Min(isOdd);
                        if (minIndex >= 0)
                        {
                            Console.WriteLine(minIndex);
                        }
                        else
                        {
                            Console.WriteLine("No matches");
                        }
                        break;
                    case "first":
                        count = int.Parse(tokens[1]);
                        isOdd = ParseOdd(tokens[2]);

                        if (count <= input.Count)
                        {
                            result = First(isOdd, count);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;
                    case "last":
                        count = int.Parse(tokens[1]);
                        isOdd = ParseOdd(tokens[2]);

                        if (count <= input.Count)
                        {
                            result = Last(count, isOdd);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        else
                        {
                            Console.WriteLine("Invalid count");
                        }
                        break;

                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        private static List<int> Last(int count, bool isOdd)
        {
            List<int> evenResult = input
                .Where(n => n % 2 == 0)
                .Reverse()
                .Take(count)
                .Reverse()
                .ToList();

            List<int> oddResult = input
                .Where(n => n % 2 == 1)
                .Reverse()
                .Take(count)
                .Reverse()
                .ToList();

            if (isOdd)
            {
                return oddResult;
            }
            else
            {
                return evenResult;
            }
        }

        private static List<int> First(bool isOdd, int count)
        {
            List<int> evenResult = input.Where(n => n % 2 == 0)
                .Take(count)
                .ToList();

            List<int> oddResult = input.Where(n => n % 2 == 1)
                .Take(count)
                .ToList();

            if (isOdd)
            {
                return oddResult;
            }
            else
            {
                return evenResult;
            }
        }

        private static int Min(bool isOdd)
        {
            int moduloExpectedResult = isOdd ? 1 : 0;
            List<int> filteredSequence =
                input
                .Where(n => n % 2 == moduloExpectedResult)
                .ToList();

            int minElement = 0;

            if (filteredSequence.Count > 0)
            {
                minElement = filteredSequence.Min();
            }
            else
            {
                return -1;
            }

            return input.LastIndexOf(minElement);
        }

        private static int Max(bool isOdd)
        {
            int moduloExpectedResult = isOdd ? 1 : 0;
            List<int> filteredSequence =
                input
                .Where(n => n % 2 == moduloExpectedResult)
                .ToList();

            int maxElement = 0;

            if (input.Count > 0)
            {
                maxElement = filteredSequence.Max();
            }
            else
            {
                return -1;
            }
            return input.LastIndexOf(maxElement);
        }

        private static bool ParseOdd(string str)
        {
            return str == "odd" ? true : false;
        }
        private static List<int> Exhange(int index)
        {
            List<int> firstHalf = input.Take(index + 1).ToList();
            List<int> secondHalf = input.Skip(index + 1).ToList();

            return secondHalf.Concat(firstHalf).ToList();
        }
    }
}
