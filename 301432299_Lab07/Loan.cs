using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _301432299_Lab07
{
    public class Loan
    {
        protected double loanAmount;
        public const double MINIMUM_LOAN = 5000;
       public int LoanNumber { get; set; }
       public string LastName { get; set; }
       public double LoanAmount 
        {
            get => loanAmount;
            set => loanAmount = value < MINIMUM_LOAN ? MINIMUM_LOAN : value;
        }
     
    }
}
