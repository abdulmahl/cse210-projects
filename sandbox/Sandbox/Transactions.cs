using System;

namespace SuperBank
{
    public class Transactions
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public Transactions(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;
        }
    }
}