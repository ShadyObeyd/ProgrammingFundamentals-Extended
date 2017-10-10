using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.FolderSize
{
    class FolderSize
    {
        static void Main()
        {
            string[] files = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (string file in files)
            {
                FileInfo currentFile = new FileInfo(file);

                sum += currentFile.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("Output.txt", sum.ToString());
        }
    }
}
