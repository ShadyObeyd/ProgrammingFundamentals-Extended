using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string input = Console.ReadLine();
            while (input != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    int digitSum = SumOfDigits(phoneNumbers[i]);

                    if (input == $"call {phoneNumbers[i]}")
                    {
                        Console.WriteLine($"calling {names[i]}...");
                        if (digitSum % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            int minutes = digitSum / 60;
                            int seconds = digitSum % 60;
                            Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                        }
                    }
                    else if (input == $"call {names[i]}")
                    {
                        Console.WriteLine($"calling {phoneNumbers[i]}...");
                        if (digitSum % 2 != 0)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            int minutes = digitSum / 60;
                            int seconds = digitSum % 60;
                            Console.WriteLine($"call ended. duration: {minutes:d2}:{seconds:d2}");
                        }
                    }
                    else if (input == $"message {phoneNumbers[i]}")
                    {
                        Console.WriteLine($"sending sms to {names[i]}...");
                        if (digitSum % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                    }
                    else if (input == $"message {names[i]}")
                    {
                        Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                        if (digitSum % 2 != 0)
                        {
                            Console.WriteLine("busy");
                        }
                        else
                        {
                            Console.WriteLine("meet me there");
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
        static int SumOfDigits(string telehphoneNum)
        {
            int sum = 0;
            for (int i = 0; i < telehphoneNum.Length; i++)
            {
                if (telehphoneNum[i] >= '0' && telehphoneNum[i] <= '9')
                {
                    sum += telehphoneNum[i] - '0';
                }
            }
            return sum;
        }
    }
}
