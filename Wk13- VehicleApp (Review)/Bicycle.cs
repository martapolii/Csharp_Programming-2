using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk13__VehicleApp__Review_
{
    internal class Bicycle : Vehicle
    {
        //properties
        string Terrain { get; set; }
        int TireSize { get; set; }

        //constructor
        public Bicycle(string name, string brand, double price, int warranty, string store, int tireSize, string terrain) : base(name, brand, price, warranty, store) //base = recieving values from parent class 
        {
            Terrain = terrain;
            TireSize = tireSize;
        }

        // method
        public override string Operate()
        {
           return "You need to pedal!";
        }
    }
}
