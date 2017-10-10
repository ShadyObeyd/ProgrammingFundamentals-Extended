using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.HornetArmada
{
    class HornetArmada
    {
        static void Main()
        {
            Dictionary<string, long> legionActivities = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionSoldiers = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int lastActivity = int.Parse(inputTokens[0]);
                string legionName = inputTokens[1];
                string soldierType = inputTokens[2];
                int soldierCount = int.Parse(inputTokens[3]);

                if (!legionActivities.ContainsKey(legionName))
                {
                    legionActivities.Add(legionName, lastActivity);
                    legionSoldiers.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionSoldiers[legionName].ContainsKey(soldierType))
                {
                    legionSoldiers[legionName][soldierType] = 0;
                }

                if (legionActivities[legionName] < lastActivity)
                {
                    legionActivities[legionName] = lastActivity;
                }

                legionSoldiers[legionName][soldierType] += soldierCount;
            }

            string[] tokens = Console.ReadLine().Split('\\');

            if (tokens.Length == 1)
            {

                string soldierType = tokens[0];

                foreach (KeyValuePair<string, long> activity in legionActivities
                    .OrderByDescending(a => a.Value))
                {
                    if (legionSoldiers[activity.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{activity.Value} : {activity.Key}");
                    }
                }
            }
            else
            {
                long activity = long.Parse(tokens[0]);
                string soldierType = tokens[1];

                foreach (var soldier in legionSoldiers
                    .Where(s => s.Value.ContainsKey(soldierType))
                    .OrderByDescending(s => s.Value[soldierType]))
                {

                    if (legionActivities[soldier.Key] < activity)
                    {
                        Console.WriteLine($"{soldier.Key} -> {soldier.Value[soldierType]}");
                    }
                }
            }
        }
    }
}
