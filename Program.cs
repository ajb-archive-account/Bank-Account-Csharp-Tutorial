using System;

namespace BankAccount_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling the 'BankAccount' constructor created in BankAccount.cs
            var account = new BankAccount("Dave Davison", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial ballance.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
        }
    }
}
