using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    abstract class Account
    {
        //properties
        public double Balance {get; set;} // account balance
        public string Name { get; set; } //name of the client who owns the acccount
        public int Number { get; set; } // account number

        //constructor
        public Account(int number, string name, double balance)
        {
            Number = number;
            Name = name;
            Balance = balance;
        }

        //methods
        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);
    }
}
