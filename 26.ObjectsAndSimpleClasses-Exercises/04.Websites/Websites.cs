using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
    class Websites
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<Website> websites = new List<Website>();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string host = tokens[0];
                string domain = tokens[1];
                List<string> querries = new List<string>();

                if (tokens.Length > 2)
                {
                    querries = tokens[2].Split(',').ToList();
                }
                else
                {
                    querries = new List<string>();
                }

                Website website = new Website
                {
                    Domain = domain,
                    Host = host,
                    Querries = querries
                };

                websites.Add(website);
                input = Console.ReadLine();
            }

            foreach (var website in websites)
            {
                string host = website.Host;
                string domain = website.Domain;
                List<string> querries = website.Querries;
                
                querries =
                    querries
                    .Select(q => $"[{q}]")
                    .ToList();
                
                if (querries.Count > 0)
                {
                    Console.WriteLine($"https://www.{host}.{domain}/query?={string.Join("&", querries)}");
                }
                else
                {
                    Console.WriteLine($"https://www.{host}.{domain}");
                }
            }
        }
        class Website
        {
            public string Host { get; set; }
            public string Domain { get; set; }
            public List<string> Querries { get; set; }
        }
    }
}
