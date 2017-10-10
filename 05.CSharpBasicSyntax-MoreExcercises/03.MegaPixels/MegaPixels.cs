using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MegaPixels
{
    class MegaPixels
    {
        static void Main(string[] args)
        {
            double imageWidth = int.Parse(Console.ReadLine());
            double imageHeight = int.Parse(Console.ReadLine());

            double result = (imageWidth * imageHeight) / 1000000;

            Console.WriteLine($"{imageWidth}x{imageHeight} => {Math.Round(result, 1)}MP");
        }
    }
}
