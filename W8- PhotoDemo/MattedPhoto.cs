using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W8__PhotoDemo
{
    internal class MattedPhoto : Photo
    {
        private const double PREMIUM = 10;
        public string Colour { get; set; }

        public MattedPhoto()
        {
            premium = PREMIUM;
        }

        public override string ToString()
        {
            return $" {GetType()}: {Colour} matting. {width}'' X {height}'' Price: {price:C}.";
        }
    }

}
