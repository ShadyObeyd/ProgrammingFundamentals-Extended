using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            int[] bullets = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] players = Console.ReadLine().Split(' ');

            int bulletIndex = 0;
            bool isDead = false;

            for (int i = 0; i < bullets.Length; i++)
            {
                if (bullets[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }
            }

            for (int i = 0; i < players.Length; i++)
            {
                string[] tokens = players[i].Split(',');

                string direction = tokens[1];
                int power = int.Parse(tokens[0]);
                
                switch (direction)
                {
                    case "Right":
                        bulletIndex = (bulletIndex + power) % bullets.Length;
                        break;
                    case "Left":

                        if (bulletIndex - power < 0)
                        {
                            bulletIndex = bullets.Length - (Math.Abs(bulletIndex - power) % bullets.Length);
                        }
                        else
                        {
                            bulletIndex = bulletIndex - power;
                        }
                        break;
                }

                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }
                if (bulletIndex + 1 == bullets.Length)
                {
                    bulletIndex = 0;
                }
                else
                {
                    bulletIndex += 1;
                }
            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
