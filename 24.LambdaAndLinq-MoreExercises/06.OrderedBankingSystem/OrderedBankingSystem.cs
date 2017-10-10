using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.OrderedBankingSystem
{
    class OrderedBankingSystem
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, decimal>> data = new Dictionary<string, Dictionary<string, decimal>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string bank = tokens[0];
                string account = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                if (!data.ContainsKey(bank))
                {
                    data.Add(bank, new Dictionary<string, decimal>());
                }

                if (!data[bank].ContainsKey(account))
                {
                    data[bank].Add(account, 0);
                }
                data[bank][account] += balance;

                input = Console.ReadLine();
            }
            data =
                data
                .OrderByDescending(v => v.Value.Values.Sum())
                .ThenByDescending(v => v.Value.Values.Max())
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var accountsData in data)
            {
                string bank = accountsData.Key;

                Dictionary<string, decimal> accounts = accountsData.Value;

                accounts =
                    accounts
                    .OrderByDescending(v => v.Value)
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var account in accounts)
                {
                    string person = account.Key;
                    decimal balance = account.Value;

                    Console.WriteLine($"{person} -> {balance} ({bank})");
                }
            }
        }
    }
}
