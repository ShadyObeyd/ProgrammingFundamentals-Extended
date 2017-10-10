using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] startCommands = Console.ReadLine().Split(' ').ToArray();
            double altitude = double.Parse(startCommands[0]);

            for (int i = 1; i < startCommands.Length; i += 2)
            {
                string command = startCommands[i];
                double number = double.Parse(startCommands[i + 1]);

                if (command == "up")
                {
                    altitude += number;
                }
                else if (command == "down")
                {
                    altitude -= number;
                }
            }
            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
