﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayElementEqualToTheirIndex
{
    class ArrayElementEqualToTheirIndex
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == i)
                {
                    number = arr[i];
                    Console.Write($"{number} ");
                }
            }
            Console.WriteLine();
        }
    }
}
