using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mid_Test_Ran
{
    public class BankBranch
    {
        private int branchNumber;
        private string address;
        private CheckingAccount[] accounts = new CheckingAccount[20];
        private int checkIndex = 0;
        
        public BankBranch( int branchNumber, string address)
        {
            this.branchNumber = branchNumber;
            this.address = address;
        }

        public void addAccount(BankAccount account)
        {
            if ((account.GetType() == typeof(CheckingAccount)) && checkIndex < 20)
                accounts[checkIndex++] = (CheckingAccount)account;
            else Console.WriteLine("not more room in the array");
        }

        public void printAccounts()
        {
            Console.WriteLine($"This Branch {branchNumber} - accounts:");
            for (int i = 0; i < checkIndex; i++)
                accounts[i].printBalance();
        }

    }
}
