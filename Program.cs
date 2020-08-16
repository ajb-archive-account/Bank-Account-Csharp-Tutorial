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

            // Try some deposits and withdrawls
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);

            // Get account history
            Console.WriteLine(account.GetAccountHistory());


            // // Make an account with a negative balance.
            // // 'try' a block of code. The block is executed until an exception is thrown.
            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // // 'catch' the exception (or how to handle the exception).
            // catch (ArgumentOutOfRangeException e)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(e.ToString());
            // }

            // // 'try' for a negative balance.
            // try
            // {
            //     account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            // }
            // catch (InvalidOperationException e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }
        }
    }
}
