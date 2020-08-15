using System;
using System.Collections.Generic;
// 'using', defines the scope by wich an object will be disposed (at the end). Creates an alies for a namespace. Imports types defined in other namespaces.

namespace BankAccount_Tutorial
// namespace, an area to logically organise code (only one used here).
{
    public class BankAccount
    // class, difines the kind of data and functionality it's objects will have.
    // Here it contains the definition of 'BankAccount' implementing code through the defined methods and properties.
    {
        // These are all properties of the BankAccount class, enforceing validation or other rules.
        private static int accountNumberSeed = 10000001; // private members can only be accessed by the code within the class ('BankAccount' in this case).
        public string Number { get; } // public members can be exposed outside of the class.
        public string Owner { get; set; }
        public decimal Balance
        // compute the balance when a user asks for a value. Calculate all transactions and give user the value.
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            
        }

        // Implementing a bank account, this is a constructor that initializes the objects of this account, name and initialBalance.
        public BankAccount(string name, decimal initialBalance)
        {
            // this.Balance = initialBalance; // Remove this of it wikll compute the balance twice.
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }
        // Constructors are called when you create an object using 'new'.

        // Create a List of Transactions
        private List<Transaction> allTransactions = new List<Transaction>();

        // The following two methods are enforce the rules that a balance must be positive and withdrawls must not create a negative value.
        // Methods are blocks of code that perform a single function.
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive"); // 'throw' an exception. Execution ends.
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }
    }
}