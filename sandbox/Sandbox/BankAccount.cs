using System;
using System.Collections.Generic;
using System.Text;


namespace SuperBank
{
    public class BankAccount
    {
        public string number { get; }
        public string owner { get; set; }
        public decimal balance 
        { 

            get 
            {
                decimal balance = 0;
                foreach (var item in AllTransactions)
                {
                    balance += item.Amount;
                }
                return balance;

            } 

        }

        private static int accountNumberSeed = 1234567890;
        private List<Transactions> AllTransactions = new List<Transactions>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.owner = name;
            MakeDeposit(initialBalance, DateTime.Now,"Initial Balance");
            this.number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");    
            }
            var deposit = new Transactions(amount, date, note);
            AllTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");               
            }

            if (balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal.");
            }
            var withdrawal = new Transactions(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }


        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date:\t\tAmount:\tNote:");
            foreach (var item in AllTransactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t${item.Amount}\t{item.Note}");
            }
            return report.ToString();
        }
    }
}