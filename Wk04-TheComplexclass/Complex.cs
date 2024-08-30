using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ComplexApp_SEC402
{
    internal class Complex
    {
// PROPERTIES: 
            /* to create a property type "prop + tab + tab =
            public int MyProperty { get; set; }
            */
        // auto-implmented properties:
        public int Real { get; }
        //absent setter = read-only property
        public int Imaginary { get; }
       
        // calculated/COMPUTED properties:
        public double Modulus
        {
            get
            {
                return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            } // ^ use math class method to help with calculations
        }
        public double Argument
        {
            get
            {
                return Math.Atan(Imaginary / Real);
            }
        }
        // factory property:
        public static Complex Zero
        {
            get
            {
                return new Complex(0, 0);
            }
        }
// CONSTRUCTORS:
        // default constructor:
        public Complex()
        {
            Real = 1;
            Imaginary = 1;
        }
        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public override string ToString()
        {
            return $"({Real},{Imaginary})";
        }
// OVERLOADED OPERATORS 
        //overloading + operator:
        public static Complex operator +(Complex leftHandSide, Complex rightHandSide)
        {
            int newReal = leftHandSide.Real + rightHandSide.Real;
            int newImaginary = leftHandSide.Imaginary + rightHandSide.Imaginary;

            return new Complex(newReal, newImaginary);
        }
        //overloading - operator:
        public static Complex operator -(Complex leftHandSide, Complex rightHandSide)
        {
            int newReal = leftHandSide.Real - rightHandSide.Real;
            int newImaginary = leftHandSide.Imaginary - rightHandSide.Imaginary;

            return new Complex(newReal, newImaginary);
        }
        // overloading == (equality) operator
        public static bool operator ==(Complex leftHandSide, Complex rightHandSide)
        {
            if (leftHandSide.Real == rightHandSide.Real &&
                leftHandSide.Imaginary == rightHandSide.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            // if you define == overload, need to define difference overload as well
        // overloading != (difference) operator
        public static bool operator !=(Complex leftHandSide, Complex rightHandSide)
        {
            if (leftHandSide.Real != rightHandSide.Real ||
                leftHandSide.Imaginary != rightHandSide.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
