using System;

namespace BankAccount_Tutorial
{
    public class Transaction
    {
        // Properties of the 'Transaction' class.
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // Constructor
        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}