using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.SoftUniMessages
{
    class SoftUniMessages
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^a-zA-Z]+$");

            string incryptedMessage = Console.ReadLine();

            while (incryptedMessage != "Decrypt!")
            {
                int messageLenght = int.Parse(Console.ReadLine());

                if (pattern.IsMatch(incryptedMessage))
                {
                    Match match = pattern.Match(incryptedMessage);

                    string message = match.Groups["message"].Value;

                    if (message.Length == messageLenght)
                    {
                        string decryptedMessage = DecryptMessage(incryptedMessage, message);

                        Console.WriteLine($"{message} = {decryptedMessage}");
                    }
                }

                incryptedMessage = Console.ReadLine();
            }
        }

        private static string DecryptMessage(string incryptedMessage, string message)
        {
            string decryptedMessage = "";

            foreach (char symbol in incryptedMessage)
            {
                int index = symbol - '0';
                if (char.IsDigit(symbol) && index < message.Length)
                {
                    decryptedMessage += message[symbol - '0'];
                }
            }

            return decryptedMessage;
        }
    }
}
