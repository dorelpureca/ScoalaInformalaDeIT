using System;

namespace BankProject
{
    class Program
    {
        /*Simulate a bank account that supports opening/closing, withdrawals, and deposits of money.
        It should be possible to close an account; operations against a closed account must fail.
        Remember you are working with money so you should use an appropriate data type for it.
        
        Now you're asked to implement an economy account.
        We know that an economy account is similar to a normal bank account,
        but on each deposit gives you 0.01% extra to the deposited sum,
        and on withdrawals takes 0.02% from the withdrawed amount. 

        Now you want to have a secret account from where you are buying wine or purses.
        When you make deposits , the deposit is made in an normal account. You can't make withdrawals in october. (edited) 
        
        Now you need to introduce a new account called GameAccount, that you will use online. This account can't make withdrawals, only deposits
        Now, since you have so many types of accounts, with different purposes, you need to find a way to extract the common behavior
        
         */


        static void Main()
        {

            //var myAccount = new BankAccount("Dorel", "Pureca", "3300",10000,true);

            //myAccount.Withdrawal(1000);
            //Console.WriteLine($"My current balance is {myAccount.Balance}");

            //myAccount.Deposit(5000);
            //Console.WriteLine($"My current balance is {myAccount.Balance}");

            //myAccount.CloseAccount();


            //var myEconomyAccount = new EconomyAccount("Dorel", "Pureca", "9900", 10000, true);
            //myEconomyAccount.Withdrawal(1000);
            //Console.WriteLine($"My current balance is {myEconomyAccount.Balance}");

            //myEconomyAccount.Deposit(000);
            //Console.WriteLine($"My current balance is {myEconomyAccount.Balance}");

            //myEconomyAccount.CloseAccount();


            //var mySecretAccount = new EconomyAccount("Dorel", "Pureca", "9900", 10000, true);
            //mySecretAccount.Withdrawal(1000);
            //Console.WriteLine($"My current balance is {mySecretAccount.Balance}");

            //mySecretAccount.Deposit(000);
            //Console.WriteLine($"My current balance is {mySecretAccount.Balance}");

            //mySecretAccount.CloseAccount();

            //var myGameAccount = new GameAccount("Dorel", "Pureca", "9900", 10000, true);
            //myGameAccount.Withdrawal(1000);






            Console.ReadLine();
        }
    }
}
