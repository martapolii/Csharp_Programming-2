using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal class RealEstateSalesperson : SalesPerson, ISellable
    {
        // fields
        private double totalValueSold;
        private double totalCommissionEarned;
        private double commissionRate;

        //properties
        public double TotalValueSold 
        {
            get
            {
                return totalValueSold;
            }
            set
            {
                totalValueSold = value;
            }
        }
        public double TotalCommissionEarned
        {
            get
            {
                return totalCommissionEarned;
            }
            set
            {
                totalCommissionEarned = value;
            }
        }
        public double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                commissionRate = value;
            }
        }

        public RealEstateSalesperson(string firstName, string lastName, double commissionRate) : base(firstName, lastName)
        {
            TotalValueSold = totalValueSold =0;
            TotalCommissionEarned = 0;
            CommissionRate = commissionRate;
        }

        // Methods from interface
         public void SalesSpeech()
        {
            Console.WriteLine($"My name is {base.ToString()}. I am a seasoned real estate agent in the GTA and only charge a commission rate of {commissionRate}. Let me help you find your dream home!");
            Console.WriteLine();

        }

        public void MakeSale(int houseValue)
        {
            TotalValueSold += houseValue;
            TotalCommissionEarned = (totalValueSold + houseValue) * commissionRate;
        }
    }
}
