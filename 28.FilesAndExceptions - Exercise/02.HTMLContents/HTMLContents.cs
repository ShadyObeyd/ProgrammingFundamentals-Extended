using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.HTMLContents
{
    class HTMLContents
    {
        static void Main()
        {
            string newLine = Environment.NewLine;
            string path = "index.html";
            File.AppendAllText(path, "<!DOCTYPE html>" + newLine);
            File.AppendAllText(path, "<html>" + newLine);
            File.AppendAllText(path, "<head>" + newLine);

            string title = string.Empty;
            List<string[]> body = new List<string[]>();

            while (true)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                if (inputTokens[0] == "exit")
                {
                    break;
                }
                else if (inputTokens[0] == "title")
                {
                    title = inputTokens[1];
                }
                else
                {
                    body.Add(inputTokens);
                }
            }

            File.AppendAllText(path, $"\t<title>{title}</title>" + newLine);
            File.AppendAllText(path, "</head>" + newLine);
            File.AppendAllText(path, "<body>" + newLine);

            foreach (string[] tags in body)
            {
                string tag = tags[0];
                string content = tags[1];

                File.AppendAllText(path, $"\t<{tag}>{content}</{tag}>" + newLine);
            }

            File.AppendAllText(path, "</body>" + newLine);
            File.AppendAllText(path, "</html>" + newLine);
        }
    }
}
