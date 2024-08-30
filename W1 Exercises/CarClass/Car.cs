using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClass
{
    internal class Car
    {
        // fields
        // - = private

        private int year;
        private string manufacturer;
        private string model;
        private bool isDrivable;
        private double price;

        // constructor:

        public Car(int year, string manufacturer, string model, double price, bool isDrivable = true) //this is a deafult value
        {
            this.year = year;
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.isDrivable = isDrivable;
        }

        //an "action member" (a method that defines a class behaviour) 
        public override string ToString()
        {
            //need to return a string
            // syntax: return $"";
            return $"Year: {year}. Manufacturer: {manufacturer}. Model: {model}. Price: {price:C}. Is drivable? {isDrivable}.";
        }



    }
}
