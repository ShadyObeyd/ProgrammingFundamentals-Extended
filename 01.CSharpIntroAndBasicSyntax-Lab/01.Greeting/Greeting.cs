using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}!");
        }
    }
}