using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGalery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int dayTaken = int.Parse(Console.ReadLine());
            int monthTaken = int.Parse(Console.ReadLine());
            int yearTaken = int.Parse(Console.ReadLine());
            int hourTaken = int.Parse(Console.ReadLine());
            int minutesTaken = int.Parse(Console.ReadLine());
            int photoSize = int.Parse(Console.ReadLine());
            int photoWidth = int.Parse(Console.ReadLine());
            int photoHeight = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{photoNumber:d4}.jpg");
            Console.WriteLine($"Date Taken: {dayTaken:d2}/{monthTaken:d2}/{yearTaken} {hourTaken:d2}:{minutesTaken:d2}");
            if (photoSize < 1000)
            {
                Console.WriteLine($"Size: {photoSize}B");
            }
            else if (photoSize >= 1000 && photoSize < 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000.0}KB");
            }
            else if (photoSize >= 1000000)
            {
                Console.WriteLine($"Size: {photoSize / 1000000.0}MB");
            }
            if (photoWidth > photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (landscape)");
            }
            else if (photoHeight > photoWidth)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (portrait)");
            }
            else if (photoWidth == photoHeight)
            {
                Console.WriteLine($"Resolution: {photoWidth}x{photoHeight} (square)");
            }
        }
    }
}
