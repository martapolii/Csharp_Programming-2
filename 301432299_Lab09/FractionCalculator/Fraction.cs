using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public class Fraction
    {   // properties
        public int Numerator { get; set; }
        public int Denominator { get; set; }
        // constructor
        public Fraction(int numerator = 0, int denominator = 1)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Add fractions
        public static Fraction Add(Fraction left, Fraction right)
        {
            int numerator = (left.Numerator * right.Denominator) + (right.Numerator * left.Denominator);
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }
        // Subtract fractions
        public static Fraction Subtract(Fraction left, Fraction right)
        {
            int numerator = (left.Numerator * right.Denominator) - (right.Numerator * left.Denominator);
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }
        // ToString
        public override string ToString()
        {
            return $"[{Numerator}, {Denominator}]";
        }

        // Multiply fractions
           // numerator = numerator 1 x numerator 2
           // denominator = denominator 1 x denominator 2
        public static Fraction Multiply(Fraction left, Fraction right)
        {
            int numerator = left.Numerator * right.Numerator;
            int denominator = left.Denominator * right.Denominator;
            return new Fraction(numerator, denominator);
        }

        // Divide fractions 
            // multiply by the inverse
            // numerator = left numerator x right denominator
            // denominator = left denominator x right numerator 
        public static Fraction Divide(Fraction left, Fraction right)
        {
            int numerator = left.Numerator * right.Denominator;
            int denominator = left.Denominator * right.Numerator;
            return new Fraction(numerator, denominator);
        }

        /* noticed I was not getting simplified fractions as my results, which is very impractical
           needed to simplify the fractions (below is the presudo code I used to figure out a method for this)
           - this is done by finding the greatest common factor and dividing both the numerator and denominator by it
            - to find the greatest common factor:
                - find a number that the numerator and denominator are both divisible by 
                - will need a loop that iterates through divisions until the denominator can no longer be divided further (is 0) 
                - can divide the numerator by the denominator
                - then divide the denominator by the remainder 
                - the remainder becomes the new denominator and the old denominator becomes the numerator 0 - I think
                - then repeat until the remainder becomes 0 (denominator cannot be 0)
                - the previous numerator is the GCF
              **FULL TRANSPARENCY - my code for this method was super wacky, it was tough to actually get it to work. After attempting it many times I ran it through AI to give me some suggestions on how to make it better/work, and I ended up with the below, so I cannot take full credit: 
        */
        private static int FindGCF(int numerator, int denominator)
        {
            while (denominator != 0) // loop continues until the denominator is 0
            {
                int var = denominator;
                denominator = numerator % denominator; 
                numerator = var;
            }
            return numerator;
        } // didn't have time to implement it unfortunately
    }
}
