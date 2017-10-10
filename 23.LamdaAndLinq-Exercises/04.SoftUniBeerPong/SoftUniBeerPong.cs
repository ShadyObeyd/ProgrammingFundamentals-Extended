using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniBeerPong
{
    class SoftUniBeerPong
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> data = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "stop the game")
            {
                string[] tokens = input.Split('|');
                string playerName = tokens[0];
                string team = tokens[1];
                int pointsMade = int.Parse(tokens[2]);

                if (!data.ContainsKey(team))
                {
                    data.Add(team, new Dictionary<string, int>());
                }
                if (data[team].Count < 3)
                {
                    data[team].Add(playerName, pointsMade);
                }

                input = Console.ReadLine();
            }
            int possitionCntr = 0;

            

            var sortedData =
                data
                .OrderByDescending(v => v.Value.Sum(p => p.Value))
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in sortedData)
            {
                string team = item.Key;
                
                Dictionary<string, int> teamData = item.Value;

                var sortedTeamData =
                    teamData
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                if (sortedTeamData.Count == 3)
                {
                    possitionCntr++;
                    Console.WriteLine($"{possitionCntr}. {team}; Players:");

                    foreach (KeyValuePair<string, int> playerAndScore in sortedTeamData)
                    {
                        string player = playerAndScore.Key;
                        int pointsMade = playerAndScore.Value;

                        Console.WriteLine($"###{player}: {pointsMade}");
                    }
                }
            }
        }
    }
}
