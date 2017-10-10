using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OptimizedBankingSystem
{
    class OptimizedBankingSystem
    {
        static void Main()
        {
            string input = Console.ReadLine();

            List<BankAccount> accounts = new List<BankAccount>();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                string bankName = tokens[0];
                string personName = tokens[1];
                decimal balance = decimal.Parse(tokens[2]);

                BankAccount acc = new BankAccount
                {
                    Name = personName,
                    Bank = bankName,
                    Balance = balance
                };

                accounts.Add(acc);

                input = Console.ReadLine();
            }

            accounts =
                accounts
                .OrderByDescending(a => a.Balance)
                .ThenBy(a => a.Bank)
                .ToList();

            foreach (BankAccount account in accounts)
            {
                string personName = account.Name;
                string bankName = account.Bank;
                decimal balance = account.Balance;

                Console.WriteLine($"{personName} -> {balance} ({bankName})");
            }
        }
        class BankAccount
        {
            public string Name { get; set; }
            public string Bank { get; set; }
            public decimal Balance { get; set; }
        }
    }
}
