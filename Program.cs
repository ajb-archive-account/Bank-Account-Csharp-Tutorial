using System;

namespace BankAccount_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dave Davison", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial ballance.");

            account.MakeWithdrawal(550, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(1231, DateTime.Now, "Pay Day!");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(52, DateTime.Now, "Eating Out");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(14, DateTime.Now, "Spotify");
            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
