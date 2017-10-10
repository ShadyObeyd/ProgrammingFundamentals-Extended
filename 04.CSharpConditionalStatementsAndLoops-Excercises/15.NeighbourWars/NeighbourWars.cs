using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NeighbourWars
{
    class NeighbourWars
    {
        static void Main(string[] args)
        {
            int PeshoDmg = int.Parse(Console.ReadLine());
            int GoshoDmg = int.Parse(Console.ReadLine());

            int turns = 1;
            int PeshoHP = 100;
            int GoshoHP = 100;

            while (true)
            {
                if (turns % 2 == 0)
                {
                    PeshoHP -= GoshoDmg;
                    if (GoshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turns}th round.");
                        break;
                    }
                    else if (PeshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turns}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHP} health.");
                }
                if (turns % 2 == 1)
                {
                    GoshoHP -= PeshoDmg;
                    if (GoshoHP <= 0)
                    {
                        Console.WriteLine($"Pesho won in {turns}th round.");
                        break;
                    }
                    else if (PeshoHP <= 0)
                    {
                        Console.WriteLine($"Gosho won in {turns}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHP} health.");
                }
                if (turns % 3 == 0)
                {
                    GoshoHP += 10;
                    PeshoHP += 10;
                }
                turns++;
            }



        }
    }
}
