using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RegisteredUsers
{
    class RegisteredUsers
    {
        static void Main()
        {
            Dictionary<string, DateTime> usersData = new Dictionary<string, DateTime>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string userName = tokens[0];
                DateTime dateAdded = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                usersData[userName] = dateAdded;
                
                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> sortedData =
                usersData
                .Reverse()
                .OrderBy(d => d.Value)
                .Take(5)
                .OrderByDescending(d => d.Value)
                .ToDictionary(u => u.Key, d => d.Value);

            foreach (var kvp in sortedData)
            {
                Console.WriteLine(kvp.Key);
            }
        }
    }
}
