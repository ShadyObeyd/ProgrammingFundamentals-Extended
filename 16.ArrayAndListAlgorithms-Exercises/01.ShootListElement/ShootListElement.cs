using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ShootListElement
{
    class ShootListElement
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> list = new List<int>();
            int lastRemoved = 0;

            while (true)
            {
                if (input == "bang")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        break;
                    }
                    double average = list.Average();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] < average)
                        {
                            lastRemoved = list[i];
                            list.RemoveAt(i);
                            Console.WriteLine($"shot {lastRemoved}");
                            break;
                        }
                        else if (list.Count == 1)
                        {
                            lastRemoved = list[0];
                            list.RemoveAt(0);
                            Console.WriteLine($"shot {lastRemoved}");
                            break;
                        }
                    }
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i]--;
                    }
                }
                else if (input == "stop")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine($"you shot them all. last one was {lastRemoved}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"survivors: {string.Join(" ", list)}");
                        break;
                    }
                }
                else
                {
                    int elementToinsert = int.Parse(input);
                    list.Insert(0, elementToinsert);
                }
                input = Console.ReadLine();
            }
        }
    }
}
