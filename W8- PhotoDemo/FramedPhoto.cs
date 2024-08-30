using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8__PhotoDemo
{
    internal class FramedPhoto : Photo
    {
        private const double PREMIUM = 25;
        public string Material { get; set; }
        public string Style { get; set; }

        //constructor
        public FramedPhoto()
        {
            premium = PREMIUM; //Make a const for this to avoid magic numbers 
        }

        public override string ToString()
        {
            return $" {GetType()}: {Style}, {Material} frame, {width}'' X {height}'' Price: {price:C}.";
        }
    }
}
