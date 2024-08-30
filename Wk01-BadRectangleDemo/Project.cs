using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wk01_BadRectangleDemo;

namespace BadRectangleDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a new object related to the class we made:
            //BadRectangle rectangle = new BadRectangle();
            //rectangle.length = 5;
            //rectangle.width = 4;

            // using display rectangle method to display the properties of our rectangle:
            // DescribeRectangle(rectangle);


            // 1st example
            BadRectangle smallRectangle = CreateRectangle(4, 5);

            // 2nd example
            DescribeRectangle(smallRectangle);

            // 3rd example
            CalculateAndDisplayArea(smallRectangle);
        }

        static BadRectangle CreateRectangle(int width, int length)
        {
            BadRectangle myRectangle = new BadRectangle();

            myRectangle.width = width;
            myRectangle.length = length;

            return myRectangle;
        }

        static void DescribeRectangle(BadRectangle badRectangle)
        {
            Console.WriteLine($"The Length of my Rectangle is {badRectangle.length}.");
            Console.WriteLine($"The Width of my Rectangle is {badRectangle.width}.");
        }

        static void CalculateAndDisplayArea(BadRectangle badRectangle)
        {
            int area = badRectangle.width * badRectangle.length;

            Console.WriteLine($"The area of the rectangle is {area}.");
        }
    }

}
