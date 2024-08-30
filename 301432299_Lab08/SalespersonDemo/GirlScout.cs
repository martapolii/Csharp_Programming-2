using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal class GirlScout : SalesPerson, ISellable
    {
        // field
        private int numberOfBoxesSold;

        // property
        public int NumberOfBoxesSold
        {
            get
            {
                return numberOfBoxesSold;
            }
            set
            {
                numberOfBoxesSold = value;
            }
        }

        //constructor - instructions didn't ask for one, but I got an error saying I needed to implement an argument that corresponds to the required parameters of firstName and lastName from the Parent class and this is the way I was able to troubleshoot that:
        public GirlScout(string firstName, string lastName) : base(firstName, lastName)
        {
            numberOfBoxesSold = 0;
        }

        // Methods from interface
        public void SalesSpeech()
        {
            Console.WriteLine($"My name is {base.ToString()}, and I sold the highest number of Girl Scout cookies in the last season."); //"base" allows me to get first + last name from ToString method in parent class
            Console.WriteLine();
        }

        public void MakeSale(int boxesSold)
        {
            numberOfBoxesSold += boxesSold;
        }
    }
}
