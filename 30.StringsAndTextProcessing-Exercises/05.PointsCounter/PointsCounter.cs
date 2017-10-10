using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PointsCounter
{
    class PointsCounter
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine().Replace("@", "").Replace("%", "").Replace("$", "").Replace("*", "");

            while (input != "Result")
            {
                string[] tokens = input.Split('|');

                string teamName = string.Empty;
                string playerName = string.Empty;
                int points = int.Parse(tokens[2]);

                for (int i = 0; i < tokens[0].Length; i++)
                {
                    if (char.IsLower(tokens[0][i]))
                    {
                        teamName = tokens[1];
                        playerName = tokens[0];
                    }
                    else
                    {
                        teamName = tokens[0];
                        playerName = tokens[1];
                    }
                }

                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new Dictionary<string, int>());
                }

                if (!data[teamName].ContainsKey(playerName))
                {
                    data[teamName].Add(playerName, points);
                }
                else
                {
                    data[teamName][playerName] = points;
                }

                input = Console.ReadLine().Replace("@", "").Replace("%", "").Replace("$", "").Replace("*", "");
            }
            data =
                data
                .OrderByDescending(v => v.Value.Values.Sum())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var teamData in data)
            {
                string teamName = teamData.Key;

                Dictionary<string, int> playerData = teamData.Value;

                var newPlayerData =
                    playerData
                    .OrderByDescending(v => v.Value)
                    .Take(1)
                    .ToDictionary(k => k.Key, v => v.Value);

                Console.WriteLine($"{teamName} => {playerData.Values.Sum()}");

                foreach (var player in newPlayerData)
                {
                    Console.WriteLine($"Most points scored by {player.Key}");
                }
            }
        }
    }
}
