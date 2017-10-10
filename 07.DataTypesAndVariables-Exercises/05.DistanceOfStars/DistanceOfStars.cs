using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DistanceOfStars
{
    class DistanceOfStars
    {
        static void Main(string[] args)
        {
            decimal proximaCentauriDistance = 4.22m * 9450000000000;
            decimal galaxyCenterDistance = 26000 * 9450000000000;
            decimal milkyWayDiameter = 100000 * 9450000000000;
            decimal distanceToObservableUniverse = 46500000000m * 9450000000000m;

            Console.WriteLine($"{proximaCentauriDistance:e2}");
            Console.WriteLine($"{galaxyCenterDistance:e2}");
            Console.WriteLine($"{milkyWayDiameter:e2}");
            Console.WriteLine($"{distanceToObservableUniverse:e2}");
        }
    }
}
