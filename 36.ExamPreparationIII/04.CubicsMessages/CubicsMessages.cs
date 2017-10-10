using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.CubicsMessages
{
    class CubicsMessages
    {
        static void Main()
        {
            List<string> data = new List<string>();
            Regex pattern = new Regex(@"^\d+(?<message>[A-Za-z]+)[^A-Za-z]*$");

            string input = Console.ReadLine();

            while (input != "Over!")
            {
                int validMessageLenght = int.Parse(Console.ReadLine());

                Match match = pattern.Match(input);

                if (match.Success)
                {
                    string message = match.Groups["message"].Value;
                    if (message.Length == validMessageLenght)
                    {
                        string decryptedMessage = DecryptMessage(input, message);
                        data.Add($"{message} == {decryptedMessage}");
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine, data));
        }

        private static string DecryptMessage(string input, string message)
        {
            string result = string.Empty;
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    index = input[i] - '0';

                    if (index >= 0 && index < message.Length)
                    {
                        result += message[index];
                    }
                    else
                    {
                        result += " ";
                    }
                }
            }
            return result;
        }
    }
}
