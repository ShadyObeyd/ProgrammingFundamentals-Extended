using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (input == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
            }
        }
        static string ShowSuccess(string operation, string message)
        {
            string success = $"Successfully executed {operation}." +
                             "\n==============================" + 
                             $"\nMessage: {message}.";
            return success;
            
        }
        static string ShowError(string operation, int code)
        {
            string error = $"Error: Failed to execute {operation}." +
                           "\n==============================" + 
                           $"\nError Code: {code}.";
            if (code  < 0)
            {
                error += "\nReason: Internal System Failure.";
            }
            else
            {
                error += "\nReason: Invalid Client Data.";
            }
            return error;
        }


    }
}
