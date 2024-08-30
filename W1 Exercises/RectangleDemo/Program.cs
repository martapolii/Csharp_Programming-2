using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace RectangleDemo
{ // can define a class in same project (outside existing program class that contains the main method or in a seperate file
    public class Rectangle
    {
        // FIELDS 
        // access level is private 
        private int length;
        private int width;


        /* CONSTRUCTOR 
         * - same name as class 
         * - defined like methods
         * - NO RETURN TYPE
         * - called immediately after object is created 
         * - put code to make your object useful 
         */

        public Rectangle(int len, int wid)
        {
            length = len;
            width = wid;
        }

        // may contain action members that is normally called methods
        public int GetArea() //dynamic (called by object) 
        {
            return length * width;
        }

        // method to print the object 
        public override string ToString()
        {
            return $"Length: {length}, width {width}.";
        }

        //method to see if two objects are the same:
        public static void AreSimilar(Rectangle object1, Rectangle object2)
        {
          if (object1.length == object2.length && object1.width == object2.width) 
            {
                Console.WriteLine("The two rectangles are the same.");
            } 
            else 
            {
                Console.WriteLine("The two rectangles are not the same."); 
            }
        }

        // How to compare area:

        public static void CompareArea(Rectangle object1, Rectangle object2)
        {
            //1st need to calculate the area for each rectangle 
            int area1 = object1.GetArea();
            int area2 = object2.GetArea();

            if (area1 == area2)
            {
                Console.WriteLine($"The area of rectangle 1 ({area1}) and rectangle 2 ({area2}) are equal.");
            }
            else if (area1 > area2)
            {
                Console.WriteLine($"The area of rectangle 1 ({area1}) is larger than the area of rectangle 2 ({area2}).");
            }
            else 
            {
                Console.WriteLine($"The area of rectangle 2 ({area2}) is greater than that of area 1 ({area1}).");
            }

        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {

            //1. create an object 
            Rectangle myRectangle = new Rectangle(8, 5);
            //print it
            //Console.WriteLine(myRectangle.ToString());
            Console.WriteLine(myRectangle);
            //print the area
            int area = myRectangle.GetArea();
            Console.WriteLine($"The area of this triangle is: {area}.");
            Console.WriteLine();

            Rectangle myRectangle2 = new Rectangle(5, 3);
            Console.WriteLine(myRectangle2.ToString());
            Console.WriteLine($"The area of my rectangle is: {myRectangle2.GetArea()}.");
            Console.WriteLine();

            Rectangle myRectangle3 = new Rectangle(20,10);
            Console.WriteLine(myRectangle3);
            Console.WriteLine($"The area of this rectangle is: {myRectangle3.GetArea()}.");
            Console.WriteLine();


            // to see if two objects are similar:
            Console.WriteLine("Method to conmpare if two objects from the rectangle class are similar:");
            Rectangle.AreSimilar(myRectangle, myRectangle3);

            Rectangle same = new Rectangle(5, 5);
            Rectangle same2 = new Rectangle(5, 5);

            Rectangle.AreSimilar(same, same2);

            // to compare areas:
            Console.WriteLine();
            Rectangle.CompareArea(myRectangle, myRectangle2);
            Rectangle.CompareArea(myRectangle, myRectangle3);
            Rectangle.CompareArea(myRectangle, myRectangle2);
            Rectangle.CompareArea(same, same2);
     

          

            
   







        }
    }
}
