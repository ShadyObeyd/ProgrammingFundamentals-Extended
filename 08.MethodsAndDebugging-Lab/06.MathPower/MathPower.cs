using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double poweredNum = PoweredNumMethod(num, power);
            Console.WriteLine(poweredNum);
        }
        static double PoweredNumMethod (double number, double powerOfNum)
        {
            return Math.Pow(number, powerOfNum);
        }
    }
}
