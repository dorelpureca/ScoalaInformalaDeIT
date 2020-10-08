using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BankProject
{
    public class BankAccount : IAccount
    {
        protected string firstName;
        protected string lastName;
        protected string iban;
        protected decimal balance=0M;
        protected bool state = false;

        public BankAccount(string firstName, string lastName, string iban, decimal balance, bool state)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.iban = iban;
            this.balance = balance;
            this.state = state;
        }

        public string OwnerFirstName
        {
            get { return firstName; }
        }
        public string OwnerLastName
        {
            get { return lastName; }
        }

        public string OwnerFullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        public string Iban
        {
            get { return iban; }
        }

        public decimal Balance
        {
            get { return balance; }
        }    
        
        public void CloseAccount()
        {
            state = false;
        }

        public virtual void Withdrawal(decimal amount)
        {
            if (state)
            {
                if (balance - amount >=0)
                    balance -= amount;
                else
                    Console.WriteLine("Insuficient funds!");
            }
            
            else
                Console.WriteLine("Bank account closed!");
        }
        public virtual void Deposit(decimal amount)
        {
            if (state)
                balance += amount;
            else
                Console.WriteLine("Bank account closed!");
        }
    }
    
}
