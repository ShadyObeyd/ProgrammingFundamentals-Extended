using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string characterName = Console.ReadLine();
            int currentHP = int.Parse(Console.ReadLine());
            int maxHP = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine("Health: " + "|" + new string('|', currentHP) + new string('.', maxHP - currentHP) + "|");
            Console.WriteLine("Energy: " + "|" + new string('|', currentEnergy) + new string('.', maxEnergy - currentEnergy) + "|");

        }
    }
}
