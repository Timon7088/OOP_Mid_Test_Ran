using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mid_Test_Ran
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ran = new Customer(789789789, "Ran", 050-1111111);
            CheckingAccount account1 = new CheckingAccount(2223, ran, 4500);
            CheckingAccount account2 = new CheckingAccount(670, ran, 9000);

            account1.deposit(67000);
            account1.withdraw(60000);
            account1.printBalance();
            account2.deposit(89000);
            account2.withdraw(45000);
            account2.printBalance();

            BankBranch branch = new BankBranch(653, "בנק פועלים נתניה");
            branch.addAccount(account1);
            branch.addAccount(account2);
            branch.printAccounts();

        }
    }
}
