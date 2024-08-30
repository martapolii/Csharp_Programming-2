using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk04__TheComplexClass
{
    internal class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }

        public double Modulus
        {
            get
            {
                double modulus = Math.Sqrt(Real * Real + Imaginary * Imaginary);
                // OR return Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
                return modulus;
            }
        }

        public double Argument
        {
            get
            {
                return Math.Atan(Imaginary / Real);
            }
        }

        public static Complex Zero
        {
            get
            {
                return new Complex(0, 0);
            }
        }

        // Constructors:
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
            return $"({Real}, {Imaginary})";
        }

        public static Complex operator +(Complex leftHandSide, Complex rightHandSide)
        {
            int newReal = leftHandSide.Real + rightHandSide.Real;
            int newImaginary = leftHandSide.Imaginary + rightHandSide.Imaginary;
            return new Complex(newReal, newImaginary);
        }
        public static Complex operator -(Complex leftHandSide, Complex rightHandSide)
        {
            int newReal = leftHandSide.Real - rightHandSide.Real;
            int newImaginary = leftHandSide.Imaginary - rightHandSide.Imaginary;

            return new Complex(newReal, newImaginary);
        }

        public static bool operator ==(Complex leftHandSide, Complex rightHandSide)
        {
            if (leftHandSide.Real == rightHandSide.Real && leftHandSide.Imaginary == rightHandSide.Imaginary)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool operator !=(Complex leftHandSide, Complex rightHandSide)
        {
            if (leftHandSide.Real != rightHandSide.Real || leftHandSide.Imaginary != rightHandSide.Imaginary)
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
    

