using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UserLogins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> userData = new Dictionary<string, string>();

            string[] input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "login")
            {
                string userName = input[0];
                string password = input[1];


                userData[userName] = password;

                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            int failedCntr = 0;

            while (input[0] != "end")
            {
                string userName = input[0];
                string password = input[1];

                if (!userData.ContainsKey(userName) || userData[userName] != password)
                {
                    Console.WriteLine($"{userName}: login failed");
                    failedCntr++;
                }
                else
                {
                    Console.WriteLine($"{userName}: logged in successfully");
                }
                input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine($"unsuccessful login attempts: {failedCntr}");
        }
    }
}
