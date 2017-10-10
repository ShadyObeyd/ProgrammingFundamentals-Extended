using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.BalisticsTraining
{
    class BalisticsTraining
    {
        static void Main(string[] args)
        {
            double[] targetAndCoordinates = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            string[] startingCommands = Console.ReadLine().Split(' ').ToArray();

            double target = 0.0;
            double coordinates = 0.0;

            for (int i = 0; i < startingCommands.Length - 1; i += 2)
            {
                string command = startingCommands[i];
                double currNum = double.Parse(startingCommands[i + 1]);

                switch (command)
                {
                    case "up":
                        coordinates += currNum;
                        break;
                    case "down":
                        coordinates -= currNum;
                        break;
                    case "left":
                        target -= currNum;
                        break;
                    case "right":
                        target += currNum;
                        break;
                }
            }
            if (targetAndCoordinates[0] == target && targetAndCoordinates[1] == coordinates)
            {
                Console.WriteLine($"firing at [{targetAndCoordinates[0]}, {targetAndCoordinates[1]}]");
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine($"firing at [{target}, {coordinates}]");
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
