using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9__Polymorphism
{
    internal abstract class GeometricFigure // an Abstract Class
    {
        private double height;
        private double width;
        protected double area; //protected so this class children classes can access it, but not outside the class

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public double Area // this is a concrete member
        {
            get
            {
                return area;
            }
        }


        public abstract void ComputeArea(); // this is an ABSTRACT METHOD - does not have a body
        // any child classes will HAVE to implement this method
    }
}
