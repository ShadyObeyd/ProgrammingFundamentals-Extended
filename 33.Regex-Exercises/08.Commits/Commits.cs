using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.Commits
{
    class Commits
    {
        class Commit
        {
            public string Hash { get; set; }
            public string Message { get; set; }
            public int Additions { get; set; }
            public int Deletions { get; set; }

            public Commit (string hash, string message, int additions, int deletions)
            {
                this.Hash = hash;
                this.Message = message;
                this.Additions = additions;
                this.Deletions = deletions;
            }
        }
        static void Main()
        {
            Regex pattern = new Regex(@"https:\/{2}github\.com\/(?<username>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z_-]+)\/commit\/(?<hash>[0-9A-Fa-f]{40}),(?<message>[^\n]+),(?<additions>[0-9]+),(?<deletions>[0-9]+)");
            var data = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            string input = Console.ReadLine();

            while (input != "git push")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);

                    string username = match.Groups["username"].Value;
                    string repo = match.Groups["repo"].Value;
                    string hash = match.Groups["hash"].Value;
                    string message = match.Groups["message"].Value;
                    int additions = int.Parse(match.Groups["additions"].Value);
                    int deletions = int.Parse(match.Groups["deletions"].Value);

                    Commit commit = new Commit(hash, message, additions, deletions);

                    if (!data.ContainsKey(username))
                    {
                        data.Add(username, new SortedDictionary<string, List<Commit>>());
                    }

                    if (!data[username].ContainsKey(repo))
                    {
                        data[username].Add(repo, new List<Commit>());
                    }

                    data[username][repo].Add(commit);
                }
                input = Console.ReadLine();
            }

            foreach (var userData in data)
            {
                string username = userData.Key;
                SortedDictionary<string, List<Commit>> reposData = userData.Value;

                Console.WriteLine($"{username}:");

                foreach (var repoData in reposData)
                {
                    string repo = repoData.Key;
                    List<Commit> commits = repoData.Value;
                    Console.WriteLine($"  {repo}:");
                    int totalAdditions = commits.Sum(c => c.Additions);
                    int totalDeletions = commits.Sum(c => c.Deletions);
                    
                    foreach (Commit commit in commits)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }
                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
