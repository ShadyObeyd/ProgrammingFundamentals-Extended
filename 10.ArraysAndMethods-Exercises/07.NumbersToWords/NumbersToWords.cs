using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                string numInLetters = string.Empty;

                string[] ones = {null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                string[] teens = {null, "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { null, null, "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                string[] hunderds = { null, "one-hundred", "two-hundred", "three-hundred", "four-hundred", "five-hundred", "six-hundred", "seven-hundred", "eight-hundred", "nine-hundred" };

                if (numbers < -999)
                {
                    numInLetters = "too small";
                }
                else if (numbers > 999)
                {
                    numInLetters = "too large";
                }
                else if (numbers >= 100 && numbers <= 999)
                {
                    if (numbers % 100 == 0)
                    {
                        numInLetters = hunderds[numbers / 100];
                    }
                    else if (numbers % 100 <= 10)
                    {
                        if (numbers % 100 == 10)
                        {
                            numInLetters = hunderds[numbers / 100] + " and ten";
                        }
                        else
                        {
                            numInLetters = hunderds[numbers / 100] + " and " + ones[(numbers % 10) % 10];
                        }
                    }
                    else if (numbers % 100 >= 11 && numbers % 100 < 20)
                    {
                        numInLetters = hunderds[numbers / 100] + " and " + teens[(numbers % 10) % 10];
                    }
                    else if (numbers % 100 > 19)
                    {
                        numInLetters = hunderds[numbers / 100] + " and " + tens[(numbers / 10) % 10] + " " + ones[(numbers % 10) % 10];
                    }
                }
                else if (numbers >= -999 && numbers <= -100)
                {
                    int newNum = Math.Abs(numbers);
                    if (newNum % 100 == 0)
                    {
                        numInLetters = "minus " + hunderds[newNum / 100];
                    }
                    else if (newNum % 100 <= 10)
                    {
                        if (newNum % 100 == 10)
                        {
                            numInLetters = "minus " + hunderds[newNum / 100] + " and ten";
                        }
                        else
                        {
                            numInLetters = "minus " + hunderds[newNum / 100] + " and " + ones[(newNum % 10) % 10];
                        }
                    }
                    else if (newNum % 100 >= 11 && newNum % 100 < 20)
                    {
                        numInLetters = "minus " + hunderds[newNum / 100] + " and " + teens[(newNum % 10) % 10];
                    }
                    else if (newNum % 100 > 19)
                    {
                        numInLetters = "minus " + hunderds[newNum / 100] + " and " + tens[(newNum / 10) % 10] + " " + ones[(newNum % 10) % 10];
                    }
                }
                Console.WriteLine(numInLetters);
            }
        }
    }
}
