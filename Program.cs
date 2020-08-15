using System;

namespace BankAccount_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Dave Davison", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial ballance.");
        }
    }
}
