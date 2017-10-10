using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.WineCraft
{
    class WineCraft
    {
        static List<int> grapes;
        static void Main(string[] args)
        {
            grapes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            do
            {
                for (int i = 0; i < n; i++)
                {
                    Bloom();
                }
                KillLesserGrapes(n);
            } while (IncrementationsPerSeason(n));
            PrintAliveGrapes();
        }
        static bool IncrementationsPerSeason(int num)
        {
            return grapes.Where(e => e > num).Count() >= num;
        }
        static void Bloom()
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (!IsAlive(i))
                {
                    continue;
                }

                if (IsGreaterGrape(i))
                {
                    grapes[i]++;
                    if (IsAlive(i - 1))
                    {
                        grapes[i]++;
                        grapes[i - 1]--;
                    }

                    if (IsAlive(i + 1))
                    {
                        grapes[i]++;
                        grapes[i + 1]--;
                    }
                }
                else if (IsLesserGrape(i))
                {
                    //chai-shukaria
                }
                else
                {
                    grapes[i]++;
                }
            }
        }
        static bool IsGreaterGrape(int index)
        {
            if (index <= 0 || index >= grapes.Count - 1)
            {
                return false;
            }
            return grapes[index] > grapes[index - 1] && grapes[index] > grapes[index + 1];

        }
        static bool IsLesserGrape(int index)
        {
            return IsGreaterGrape(index - 1) || IsGreaterGrape(index + 1);
        }
        static void KillLesserGrapes(int num)
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (grapes[i] <= num)
                {
                    grapes[i] = 0;
                }
            }
        }
        static bool IsAlive(int num)
        {
            if (num < 0 || num >= grapes.Count)
            {
                return false;
            }
            return grapes[num] > 0;
        }
        static void PrintAliveGrapes()
        {
            for (int i = 0; i < grapes.Count; i++)
            {
                if (IsAlive(i))
                {
                    Console.Write(grapes[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
