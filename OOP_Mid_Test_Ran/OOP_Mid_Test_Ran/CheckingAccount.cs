using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mid_Test_Ran
{
    public class CheckingAccount : BankAccount
    {
        private double overDraftLimit;

        public CheckingAccount(int accountNumber, Customer customerOwner, double overDraftLimit) : base(accountNumber, customerOwner)
        {
            this.overDraftLimit = overDraftLimit;
        }

        public override void withdraw(double amount)
        {
            if (balance + overDraftLimit >= amount)
                balance -= amount;

            else Console.WriteLine("No funds with overdraft limit");
        } 

        public override void printBalance()
        {
            Console.WriteLine($"Account number: {accountNumber}.\n Account balance: {balance}. \n Account overdraft limit: {overDraftLimit}.");
        }
                
    }
}
