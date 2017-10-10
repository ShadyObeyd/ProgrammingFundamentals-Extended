using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterThanTwoValues
{
    class GreaterThanTwoValues
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            if (inputType == "int")
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                int greaterNum = GetMax(firstNum, secondNum);
                Console.WriteLine(greaterNum);
            }
            else if (inputType == "char")
            {
                char firstLetter = char.Parse(Console.ReadLine());
                char secondLetter = char.Parse(Console.ReadLine());

                char greaterChar = GetMax(firstLetter, secondLetter);
                Console.WriteLine(greaterChar);
            }
            else if (inputType == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                string greaterString = GetMax(firstString, secondString);
                Console.WriteLine(greaterString);
            }
        }
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
