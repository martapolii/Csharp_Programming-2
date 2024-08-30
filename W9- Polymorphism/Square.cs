using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9__Polymorphism
{
    internal class Square : Rectangle
    {
        // height and width arre the same

        // need 2 constructors:

        //1. accept 2 values for height and width and force them to be the same
        public Square(double height, double width)
        {
            if (height != width)
            {
                height = width;
            }
            Height = height;
            Width = width;
        }

        //2. accept one value and use it for both height and width
        public Square(double side)
        {
            Height = side;
            Width = side;
        }
    }
}
