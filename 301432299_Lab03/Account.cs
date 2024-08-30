using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Marta Polishchuk
//301432299
//COMP123 SEC 402
//Assignment 2

namespace _301432299_Lab03
{
    internal class Account
    {
        //Constant
        private const int TRANSIT_NUMBER = 314;

        //Fields
        private static int nextAccountNumber;
        public readonly string Number;

        //Properties
        public double Balance { get; private set; }
        public List<string> Names { get; private set; }

        //Constructor: 
        static Account()
        {
            nextAccountNumber = 10000;
        }

        private Account(string number, string name, double balance)
        {
            this.Number = number;
            this.Balance = balance;
            this.Names = new List<string>();
            this.Names.Add(name);
        }

        public static Account CreateAccount(string name, double balance = 500)
        {
            string number = $"AC-{TRANSIT_NUMBER}-{nextAccountNumber}";
            nextAccountNumber++;
            return new Account(number, name, balance);
        }

        public void AddName(string name)
        {
            this.Names.Add(name);
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public override string ToString()
        {
            return $"Number: {Number}, Balance: {Balance}, Names: {string.Join(",", Names)}";
        }
    }
}
