using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Nilapdromes
{
    class Nilapdromes
    {
        static void Main()
        {
            string nilapdrome = Console.ReadLine();

            while (nilapdrome != "end")
            {
                string result = ReturnNilapdrome(nilapdrome);

                if (result.Length != 0)
                {
                    Console.WriteLine(result);
                }

                nilapdrome = Console.ReadLine();
            }
        }

        private static string ReturnNilapdrome(string nilapdrome)
        {
            int mid = nilapdrome.Length / 2;

            string border = "";
            int index = 0;
            for (int i = mid + 1; i < nilapdrome.Length; i++)
            {
                if (nilapdrome[index] == nilapdrome[i])
                {
                    border += nilapdrome[i];
                    index++;
                }
                else
                {
                    border = "";
                    index = 0;
                    if (nilapdrome[0] == nilapdrome[i])
                    {
                        border += nilapdrome[i];
                        index++;
                    }
                }
            }

            if (border.Length != 0)
            {
                int leftIndex = nilapdrome.IndexOf(border);
                int rightIndex = nilapdrome.LastIndexOf(border);

                string middle = nilapdrome.Substring(leftIndex + border.Length, rightIndex - border.Length);
                if (middle.Length != 0)
                {
                    return $"{middle}{border}{middle}";
                }
            }
            return "";
        }
    }
}
