using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.InsertList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputList = Console.ReadLine().Split('|').ToArray();

            List<string> resultList = new List<string>();

            for (int i = inputList.Length - 1; i >= 0; i--)
            {
                resultList.Add(inputList[i].Trim());
            }
            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
