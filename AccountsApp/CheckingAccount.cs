using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsApp
{
    internal class CheckingAccount: Account
    {
        //field
        private const double TRANSACTION_FEE_DEPOSIT = 5.45;
        private const double TRANSACTION_FEE_WITHDRAW = 3.25; // had to decalre two because constants can't be re-defined and we need 2 of these 

        //property
        public double Limit { get; set; } // max daily amount client can withdraw

        // constructor
        public CheckingAccount(int number, string name, double balance, double limit) : base(number, name, balance)
        {
            Limit = limit;
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
