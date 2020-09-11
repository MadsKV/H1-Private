using System;
using System.Collections.Generic;
using System.Text;

namespace Form_Bank_Account
{
    class Bank_account
    {

        public double balance;

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
