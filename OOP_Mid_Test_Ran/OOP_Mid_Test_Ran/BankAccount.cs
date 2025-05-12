using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mid_Test_Ran
{
    public abstract class BankAccount
    {
        protected int accountNumber;
        protected double balance;
        protected Customer customerOwner;

        public BankAccount(int accountNumber, Customer customerOwner)
        {
            this.accountNumber = accountNumber;
            this.customerOwner = customerOwner;
            this.balance = 0;
        }

        public void deposit(double amount)
        {
            balance += amount;
        }

        public virtual void withdraw(double amount)
        {
            if (balance >= amount)
                balance -= amount;
        }

        public virtual void printBalance()
        {
            Console.WriteLine($"Account number: {accountNumber}.\n Account balance: {balance}");
        }
    }
}
