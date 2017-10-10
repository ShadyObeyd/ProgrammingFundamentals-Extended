using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ResizeableArray
{
    class ResizeableArray
    {
        static int[] elements;
        static int elementsLenght;

        static void Main(string[] args)
        {

            string[] inputTokens = Console.ReadLine().Split(' ').ToArray();

            elements = new int[4];
            elementsLenght = 0;

            while (inputTokens[0] != "end")
            {
                string command = inputTokens[0];
                switch (command)
                {
                    case "push":
                        elements[elementsLenght] = int.Parse(inputTokens[1]);
                        elementsLenght++;
                        if (elementsLenght >= elements.Length)
                        {
                            GrowArray();
                        }
                        break;
                    case "pop":
                        elements[elementsLenght] = 0;
                        elementsLenght--;
                        break;
                    case "removeAt":
                        int index = int.Parse(inputTokens[1]);
                        ShiftArray(index);
                        elementsLenght--;
                        break;
                    case "clear":
                        elementsLenght = 0;
                        break;
                }
                inputTokens = Console.ReadLine().Split(' ').ToArray();
            }
            PrintArray();
        }
        static void PrintArray()
        {
            for (int i = 0; i < elementsLenght; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
        }
        static void GrowArray()
        {
            int[] newArray = new int[elementsLenght * 2];
            for (int i = 0; i < elementsLenght; i++)
            {
                newArray[i] = elements[i];
            }
            elements = newArray;
        }
        static void ShiftArray(int index)
        {
            for (int i = index + 1; i < elementsLenght; i++)
            {
                elements[i - 1] = elements[i];
            }
        }
    }
}
