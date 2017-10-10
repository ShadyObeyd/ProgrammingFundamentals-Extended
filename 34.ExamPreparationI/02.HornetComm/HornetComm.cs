using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.HornetComm
{
    class HornetComm
    {
        static void Main()
        {
            Regex messagePattern = new Regex(@"^\d+ <-> [A-Za-z0-9]+$");
            Regex broadcastPattern = new Regex(@"^[^\d]+ <-> [A-Za-z0-9]+$");

            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string input = Console.ReadLine();

            while (input != "Hornet is Green")
            {
                if (messagePattern.IsMatch(input))
                {
                    string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                    string recipientCode = tokens[0];
                    string message = tokens[1];

                    string reversed = new string(recipientCode.ToCharArray().Reverse().ToArray());

                    messages.Add($"{reversed} -> {message}");
                }
                else if (broadcastPattern.IsMatch(input))
                {
                    string[] tokens = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                    string message = tokens[0];
                    string frequency = tokens[1];
                    StringBuilder builder = new StringBuilder();

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsUpper(frequency[i]))
                        {
                            builder.Append(char.ToLower(frequency[i]));
                        }
                        else if (char.IsLower(frequency[i]))
                        {
                            builder.Append(char.ToUpper(frequency[i]));
                        }
                        else
                        {
                            builder.Append(frequency[i]);
                        }
                    }
                    broadcasts.Add($"{builder.ToString()} -> {message}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, broadcasts));
            }

            Console.WriteLine("Messages:");
            if (messages.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, messages));
            }
        }
    }
}
