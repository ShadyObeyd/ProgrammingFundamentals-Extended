using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main()
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");
            List<int> numbers = new List<int>();

            for (int i = 0; i < firstFile.Length; i++)
            {
                numbers.Add(int.Parse(firstFile[i]));
            }

            for (int i = 0; i < secondFile.Length; i++)
            {
                numbers.Add(int.Parse(secondFile[i]));
            }
            numbers.Sort();

            foreach (int number in numbers)
            {
                File.AppendAllText("Output.txt", $"{number}" + Environment.NewLine);
            }
        }
    }
}
