using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    public class GameAccount : BankAccount, IAccount
    {
        protected decimal balance = 0M;

        public GameAccount(string firstName, string lastName, string iban, decimal balance, bool state) : base(firstName, lastName, iban, balance, state)
        {
        }

        public override void Withdrawal(decimal amount)
        {
            Console.WriteLine("You are not allowed to withdraw money from this account");
        }
    }
}
