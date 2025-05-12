using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Mid_Test_Ran
{
    public class Customer
    {
        private int id;
        private string name;
        private int phoneNum;


        public Customer (int id, string name, int phoneNum)
        {
            this.id = id;
            this.name = name;
            this.phoneNum = phoneNum;
        }

        public void printDetails()
        {
            Console.WriteLine($"Customer id: {id}.\n Customer name: {name}.\n Customer phone number: {phoneNum}");
        }
    }
}
