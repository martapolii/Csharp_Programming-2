using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class SavingsAccount: Account
    {
        // fields
        private const double TRANSACTION_FEE_DEPOSIT = 2.25;
        private const double TRANSACTION_FEE_WITHDRAW = 1.35; // had to decalre two because constants can't be re-defined and we need 2 of these 

        // properties
        public double Interest { get; set; } // montly interest rate account pays to the client

        // constructor
        public SavingsAccount(int number, string name, double balance, double interest) : base(number, name, balance)
        {
            Interest = interest;
        }

        // methods
        public override void Deposit(double amount)
        {
            base.Balance = base.Balance + amount;
            base.Balance = Balance - TRANSACTION_FEE_DEPOSIT;
        }

        public override void Withdraw(double amount)
        {
            base.Balance = base.Balance - amount;
            base.Balance = base.Balance - TRANSACTION_FEE_WITHDRAW;
        }

    }
}
