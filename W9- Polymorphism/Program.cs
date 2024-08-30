namespace W9__Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GeometricFigure g - new GeometricFigure(); // can declare a new object, but cannot intialize it bc abstract class
            //GeometricFigure g;

            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 10;
            r.ComputeArea();
            Console.WriteLine($"The area is {r.Area}.");

            // Creating a square
            Square s1 = new Square(10, 8);
            s1.ComputeArea();
            Console.WriteLine($"The area is {s1.Area}.");

            Square s2 = new Square(5);
            s2.ComputeArea();
            Console.WriteLine($"The area is {s2.Area}.");

            //Creating a Triangle
            Triangle t = new Triangle();
            t.Width = 10;
            t.Height = 10;
            t.ComputeArea();
            Console.WriteLine($"The area is {t.Area}.");

            //using the Display() method make displaying object properties easier 
            // can change the code in only this method and display method changes evrywhere
            Display(r);
            Display(s1);
            Display(s2);
            Display(t);
        }

        // method that takes any Geometric Figure and displays its info
        public static void Display(GeometricFigure figure)
        {
            Console.WriteLine($"The area of the {figure.ToString().Replace("W9__Polymorphism.","")} is {figure.Area}.");
        }
    } // ^ polymorphism of ToString, Area, geometric figure and its child classes 
}
