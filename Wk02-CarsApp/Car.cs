using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk02_CarsApp
{
    // internal class = only available within the project 
    // (public = available outside project too)
    // rn doesnt matter bc we working with one project
    internal class Car 
    {
        private int year; // private modifier - restricts access to fields
                         //  can only be accessed within the car class 
                         // (public = accessible inside and outside the class)
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        //fully implemented property:
        public int Year
        {
            // getter
            get
            {
                return year;
            }
            //setter
            set
            {
                year = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                manufacturer = value;
            }
        }


        public Car(int year, // does not have a return type, not even void
        string manufacturer, // has arguments that can be used to initialize the corresponding private fields
        string model,
        double price,
        bool isDrivable = true) // default value for this argument is true)

        {// "this" keyword allows us to set the values for these properties outside thee class
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.isDrivable = isDrivable;
            this.price = price; 
        }

        public override string ToString()
        {
            return $"year: {year} - Manufacturer: {manufacturer} - Model: {model} - Price: {price:C} - Is Driveable: {isDrivable}";
        }
    }
    
}
