using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PhoneBook
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();
            string[] names = Console.ReadLine().Split(' ').ToArray();

            string currentName = Console.ReadLine();

            while (currentName != "done")
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == currentName)
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
                currentName = Console.ReadLine();
            }
        }
    }
}
