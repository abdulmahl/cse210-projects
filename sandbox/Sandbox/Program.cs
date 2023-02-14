using System;
using static System.Console;

namespace SuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Kendra", 10000);
            WriteLine($"\nAccount {account.number} was created for {account.owner} with ${account.balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            WriteLine($"Withdrawn: {120}");
            WriteLine($"Balance: ${account.balance}");
            
            account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
            WriteLine($"Withdrawn: {50}");
            WriteLine($"Balance: ${account.balance}");

            WriteLine(account.GetAccountHistory());
            


            // // Test that initial balance must be positive.
            // try
            // {
            //     var invalidAccount = new BankAccount("invalid", -55);
            // }
            // catch (ArgumentOutOfRangeException e)
            // {
            //     WriteLine("Exception caught creating account with negative balance");
            //     WriteLine(e.ToString());
            // }

            

            // account.MakeDeposit(-300, DateTime.Now, "Stealing");
        }   
    } 
}
