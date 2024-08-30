using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk13__VehicleApp__Review_
{
    internal class Car : Vehicle
    {
        string Fuel {get; set;}
        int NumberOfPassengers { get; set; }

        public Car(string name, string brand, double price, int warranty, string store, int numberOfPassengers, string fuel) : base(name, brand, price, warranty, store)
        {
            Fuel = fuel;
            NumberOfPassengers = numberOfPassengers;
        }

        public override string Operate()
        {
            return "You turn on the ignition!";
        }
    }
}
