using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    public class EconomyAccount : BankAccount, IAccount
    {
        public EconomyAccount(string firstName, string lastName, string iban, decimal balance, bool state) : base(firstName,lastName,iban,balance,state)
        {
        }

        public override void Withdrawal(decimal amount)
        {
            if (state)
            {
                if (balance - amount >= 0)
                    balance -= amount * 1.0002M;
                else
                    Console.WriteLine("Insuficient funds!");
            }

            else
                Console.WriteLine("Bank account closed!");
        }


        public override void Deposit(decimal amount)
        {
            if (state)
            {
                balance = balance + amount * 1.0001M;
            }
            else
            {
                Console.WriteLine("Bank account closed!");
            }
        }

        

    }
}
