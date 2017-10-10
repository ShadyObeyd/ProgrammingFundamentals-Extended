using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNASequences
{
    class DNASequences
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int l = 1; l <= 4; l++)
                    {
                        if (i + j + l >= sum)
                        {
                            Console.Write("O");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            else if (i == 2)
                            {
                                Console.Write("C");
                            }
                            else if (i == 3)
                            {
                                Console.Write("G");
                            }
                            else if (i == 4)
                            {
                                Console.Write("T");
                            }
                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            else if (j == 2)
                            {
                                Console.Write("C");
                            }
                            else if (j == 3)
                            {
                                Console.Write("G");
                            }
                            else if (j == 4)
                            {
                                Console.Write("T");
                            }
                            if (l == 1)
                            {
                                Console.Write("A");
                            }
                            else if (l == 2)
                            {
                                Console.Write("C");
                            }
                            else if (l == 3)
                            {
                                Console.Write("G");
                            }
                            else if (l == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("O ");
                        }
                        else
                        {
                            Console.Write("X");
                            if (i == 1)
                            {
                                Console.Write("A");
                            }
                            else if (i == 2)
                            {
                                Console.Write("C");
                            }
                            else if (i == 3)
                            {
                                Console.Write("G");
                            }
                            else if (i == 4)
                            {
                                Console.Write("T");
                            }
                            if (j == 1)
                            {
                                Console.Write("A");
                            }
                            else if (j == 2)
                            {
                                Console.Write("C");
                            }
                            else if (j == 3)
                            {
                                Console.Write("G");
                            }
                            else if (j == 4)
                            {
                                Console.Write("T");
                            }
                            if (l == 1)
                            {
                                Console.Write("A");
                            }
                            else if (l == 2)
                            {
                                Console.Write("C");
                            }
                            else if (l == 3)
                            {
                                Console.Write("G");
                            }
                            else if (l == 4)
                            {
                                Console.Write("T");
                            }
                            Console.Write("X ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
