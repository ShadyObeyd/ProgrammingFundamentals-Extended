using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FootballStandings
{
    class FootballStandings
    {
        class Team
        {
            public int Goals { get; set; }
            public int Points { get; set; }

            public Team (int points, int goals)
            {
                this.Goals = goals;
                this.Points = points;
            }
        }
        static void Main()
        {
            Dictionary<string, Team> data = new Dictionary<string, Team>();

            string key = Console.ReadLine();
            string escapeKey = Regex.Escape(key);
            string pattern = string.Format($@"(?<={escapeKey})(?<teamA>[A-Za-z]*)(?={escapeKey}).*(?<={escapeKey})(?<teamB>[A-Za-z]*)(?={escapeKey})[^ ]* (?<scoreA>\d+):(?<scoreB>\d+)");

            Regex teamReg = new Regex(pattern);
            string input = Console.ReadLine();

            while (input != "final")
            {
                Match teams = teamReg.Match(input);

                string teamA = ReverseString(teams.Groups["teamA"].Value.ToUpper());
                string teamB = ReverseString(teams.Groups["teamB"].Value.ToUpper());
                int scoreA = int.Parse(teams.Groups["scoreA"].Value);
                int scoreB = int.Parse(teams.Groups["scoreB"].Value);

                if (!data.ContainsKey(teamA))
                {
                    data.Add(teamA, new Team(0, 0));
                }

                if (!data.ContainsKey(teamB))
                {
                    data.Add(teamB, new Team(0, 0));
                }

                data[teamA].Goals += scoreA;
                data[teamB].Goals += scoreB;

                if (scoreA > scoreB)
                {
                    data[teamA].Points += 3;
                }
                else if (scoreB > scoreA)
                {
                    data[teamB].Points += 3;
                }
                else if (scoreA == scoreB)
                {
                    data[teamA].Points += 1;
                    data[teamB].Points += 1;
                }
                
                input = Console.ReadLine();
            }

            int cntr = 1;

            var pointsData =
                data
                .OrderByDescending(p => p.Value.Points)
                .ThenBy(n => n.Key);

            Console.WriteLine("League standings:");
            foreach (KeyValuePair<string, Team> pointData in pointsData)
            {
                string teamName = pointData.Key;
                int points = pointData.Value.Points;

                Console.WriteLine($"{cntr}. {teamName} {points}");

                cntr++;
            }
            
            Console.WriteLine("Top 3 scored goals:");

            var goalsData =
                data
                .OrderByDescending(g => g.Value.Goals)
                .ThenBy(n => n.Key)
                .Take(3);

            foreach (KeyValuePair<string, Team> goals in goalsData)
            {
                string name = goals.Key;
                int goalsScored = goals.Value.Goals;

                Console.WriteLine($"- {name} -> {goalsScored}");
            }
        }
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
