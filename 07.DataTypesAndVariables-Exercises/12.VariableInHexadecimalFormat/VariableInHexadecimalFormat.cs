using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            string hexaNum = Console.ReadLine();

            int num = Convert.ToInt32(hexaNum, 16);

            Console.WriteLine(num);
        }
    }
}