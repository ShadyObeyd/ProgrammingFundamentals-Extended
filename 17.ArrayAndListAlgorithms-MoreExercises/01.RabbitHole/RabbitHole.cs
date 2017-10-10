using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RabbitHole
{
    class RabbitHole
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split(' ').ToList();
            int totalEnergy = int.Parse(Console.ReadLine());
            int possition = 0;
            bool isBombed = false;

            while (true)
            {
                string[] tokens = path[possition].Split('|');
            
                switch (tokens[0])
                {
                    case "Right":
                        possition = (possition + int.Parse(tokens[1])) % path.Count;
                        totalEnergy -= int.Parse(tokens[1]);
                        break;
                    case "Left":
                        possition = Math.Abs(possition - int.Parse(tokens[1])) % path.Count;
                        totalEnergy -= int.Parse(tokens[1]);
                        break;
                    case "Bomb":
                        int energyTaken = int.Parse(tokens[1]);
                        totalEnergy -= energyTaken;
                        path.RemoveAt(possition);
                        possition = 0;
                        isBombed = true;
                        break;
                    case "RabbitHole":
                        Console.WriteLine("You have 5 years to save Kennedy!");
                        return;
                }
                if (totalEnergy <= 0)
                {
                    if (isBombed)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }
                }

                if (path[path.Count - 1] != "RabbitHole")
                {
                    path.RemoveAt(path.Count - 1);
                }
                path.Add("Bomb|" + totalEnergy);
            }
        }
    }
}
