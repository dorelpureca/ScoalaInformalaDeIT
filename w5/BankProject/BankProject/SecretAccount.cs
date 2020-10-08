using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankProject
{
    public class SecretAccount : BankAccount, IAccount
    {
        public SecretAccount(string firstName, string lastName, string iban, decimal balance, bool state) : base(firstName, lastName, iban, balance, state)
        {
        }

        public new void Deposit(decimal amount)
        {
            base.Deposit(amount);
        }

        public override void Withdrawal(decimal amount)
        {
            if (state)
            {
                if (DateTime.Now.Month != 10)
                {
                    if (balance - amount >= 0)
                        balance -= amount;
                    else
                        Console.WriteLine("Insuficient funds!");
                }
                else
                    Console.WriteLine("Withdrawals cannot be made in October");
            }
            else
                Console.WriteLine("Bank account closed!");
        }
    }




}
