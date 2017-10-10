using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
        }
        static void GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
