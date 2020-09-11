using System;
using System.Collections.Generic;
using System.Text;

namespace Objekter_know_how
{
    class Bank_account
    {

        double balance;

        public Bank_account(double balance)
        {
            this.balance = balance;
        }

        public double Withdraw(double withdrawAmount)
        {
            if (balance <= 0 || balance - withdrawAmount <= 0)
            {
                 throw new ArgumentException("You don't have enough money");
            }
            else
            {
                balance -= withdrawAmount;
                return balance;
            }
        }

        public double Deposit(double depositAmount)
        {
            balance += depositAmount;
            return balance;
        }

        public void Print()
        {
           Console.WriteLine(balance.ToString()); 
        }
    }
}
