using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.UserDatabase
{
    class UserDatabase
    {
        static void Main()
        {
            string path = "users.txt";

            Dictionary<string, User> users = new Dictionary<string, User>();

            string[] data = File.ReadAllLines(path);

            foreach (string userData in data)
            {
                string[] tokens = userData.Split(' ');

                User user = new User
                {
                    Username = tokens[0],
                    Password = tokens[1],
                    IsLogged = bool.Parse(tokens[2])
                };

                users.Add(user.Username, user);
            }

            while (true)
            {
                string[] inputTokens = Console.ReadLine().Split(' ');

                string username = string.Empty;
                string password = string.Empty;
                string repeatPass = string.Empty;

                if (inputTokens[0] == "exit")
                {
                    break;
                }

                switch (inputTokens[0])
                {
                    case "register":
                        username = inputTokens[1];
                        password = inputTokens[2];
                        repeatPass = inputTokens[3];

                        if (users.ContainsKey(username))
                        {
                            Console.WriteLine("The given username already exists.");
                        }
                        else if (password != repeatPass)
                        {
                            Console.WriteLine("The two passwords must match.");
                        }
                        else
                        {
                            User user = new User
                            {
                                Username = username,
                                Password = password,
                                IsLogged = false
                            };
                            users.Add(username, user);
                        }
                        break;

                    case "login":
                        username = inputTokens[1];
                        password = inputTokens[2];

                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (users[username].IsLogged)
                        {
                            Console.WriteLine("There is already a logged in user.");
                        }
                        else if (users[username].Password != password)
                        {
                            Console.WriteLine("The password you entered is incorrect.");
                        }
                        else
                        {
                            users[username].IsLogged = true;
                        }
                        break;

                    case "logout":
                        username = inputTokens[1];
                        if (!users.ContainsKey(username))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else if (!users.ContainsKey(username))
                        {
                            Console.WriteLine($"User {username} is not logged in");
                        }
                        else
                        {
                            users[username].IsLogged = false;
                        }
                        break;
                }
            }

            foreach (KeyValuePair<string, User> usersData in users)
            {
                File.WriteAllLines(path, users
                    .Values
                    .Select(u => $"{u.Username} {u.Password} {u.IsLogged}")
                    .ToArray());
            }
        }
        class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public bool IsLogged { get; set; }
        }
    }
}
