using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Marta Polishchuk
// 301432299 
// C123 Sec. 402
// Assignment 07

namespace _301432299_Lab07
{
    public class CarLoan : Loan // child of Loan class
    {
        private int year;
        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_VALID_NUMBER = 1000;
        public int LoanNumber
        {
            get => base.LoanNumber;
            set => base.LoanNumber = value > LOWEST_VALID_NUMBER ? value % 1000 : value;
        }
        public int Year
        {
            get => year;
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;
                }
                else
                {
                    year = value;
                }
            }
        }
        public string Make { get; set; }
    }
}
