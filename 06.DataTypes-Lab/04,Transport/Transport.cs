using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            double result = (double)peopleCount / 24;
            Console.WriteLine(Math.Ceiling(result));
        }
    }
}
