using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            List <string> blackList = Console.ReadLine().Split(' ').ToList();
            string fileNames = Console.ReadLine();

            List<string> result = new List<string>();
            

            while (fileNames != "end")
            {
                bool isContained = false;
                for (int i = 0; i < blackList.Count; i++)
                {
                    if (fileNames.Contains(blackList[i]))
                    {
                        isContained = true;
                    }
                }
                if (!isContained)
                {
                    result.Add(fileNames);
                }
                fileNames = Console.ReadLine();
            }
            result.Sort();
            Console.WriteLine(string.Join("\r\n", result));
        }
    }
}
