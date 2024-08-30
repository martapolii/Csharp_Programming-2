using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal abstract class SalesPerson
    {
        // Fields
        protected string firstName; //protected instead of private so derived classes could access these fields without issues
        protected string lastName;

        //Properties
        public string FirstName // need to fully implement (auto-implemented syntax resulted in issues)
        {
            get
            { 
                return firstName; 
            }
            set
            { 
                firstName = value; 
            }
                
        }
        public string LastName 
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        
        }

        // Constructor
        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //Method that returns the sale person's full name:
        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }

        internal interface ISellable
        {
            void SalesSpeech();
            void MakeSale(int s);
        }
    }
}
