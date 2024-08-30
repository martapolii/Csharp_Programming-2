using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk13__VehicleApp__Review_
{
    internal abstract class Vehicle
    {
        //properties
        string Brand { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        string Store { get; set; }
        int Warranty { get; set; }

        // constructor
        public Vehicle(string name, string brand, double price, int warranty, string store)
        {
            Brand = brand;
            Name = name;
            Price = price;
            Store = store;
            Warranty = warranty;
        }

        // method
        public abstract string Operate();
    }
}
