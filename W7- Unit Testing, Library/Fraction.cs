namespace W7__Unit_Testing__Library
{
    // this is a LIBRARY
    public class Fraction // public = this class can be seen outside this project
    {
        // auto-implemented, read only properties
        public int Top { get; }
        public int Bottom { get; }

        // Constructor
        public Fraction(int top = 0, int bottom = 1)
        {
            Top = top;
            Bottom = bottom;
        }

        // Overloaded Methods:
        public static Fraction operator +(Fraction left, Fraction right) // the arguments represent the position of the arguments around the operator
        {
            int newTop = (left.Top * right.Bottom) + (right.Top * left.Bottom); //how you add fractions
            int newBottom = left.Bottom * right.Bottom;

            return new Fraction(newTop, newBottom);
        }

        public static Fraction operator -(Fraction left, Fraction right)
        {
            if ((right.Top / right.Bottom) > (left.Top / left.Bottom))
                throw new Exception("Right operand cannot be greater than left operand"); //curly braces not needed for one statement 

            int newTop = (left.Top * right.Bottom) - (right.Top * left.Bottom);
            int newBottom = left.Bottom * right.Bottom;

            return new Fraction(newTop, newBottom);
        }

        public override string ToString()
        {
            return $"{Top}/{Bottom}";
        }

    }
}
