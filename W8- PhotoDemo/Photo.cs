using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8__PhotoDemo
{
    internal class Photo
    {
        //constants for the standard widths:
        private const double STANDARD_WIDTH1 = 8;
        private const double STANDARD_HEIGHT1 = 10;
        private const double STANDARD_PRICE1 = 3.99;

        private const double STANDARD_WIDTH2 = 10;
        private const double STANDARD_HEIGHT2 = 12;
        private const double STANDARD_PRICE2 = 5.99;

        private const double CUSTOM_PRICE = 9.99;

        // constant for framed or matted photo:
        protected double premium = 0; // 0 bc for a basic photo there is no increase in price
            // PROTECTED BC THEN CAN ACCESS PREMIUM FROM THE CHILDREN CLASS 
              // - then create constructors in each of the classes

        // fields
        public double width;
        public double height;
        protected double price;
     
        // properties 
        public double Width 
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                SetPrice();
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
                SetPrice();
            }
        }

        public double Price
        {
            get
            { 
                return price;
            }
        }

        // METHODS
        public override string ToString()
        {
           return $" {GetType()}: {width}'' X {height}'' Price: {price:C}.";
        }


        // method to set price
        // could've pasted this code in the setter for both the width and height properties, but then you are repeating code - makes sense to make a method instead:
        private void SetPrice() // this method calculates the BASE PRICE
        {
            if (Width == STANDARD_WIDTH1 && Height == STANDARD_HEIGHT1)
                price = STANDARD_PRICE1;
            else
                       if (Width == STANDARD_WIDTH2 && Height == STANDARD_HEIGHT2)
                price = STANDARD_PRICE2;
            else
                price = CUSTOM_PRICE;

            // Need to add the premium:
            price += premium;
        }
    }
}
