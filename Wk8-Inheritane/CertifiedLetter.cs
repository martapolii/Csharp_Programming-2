using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk8_Inheritance
{
    internal class CertifiedLetter : Letter // this is a child class of Letter -  - colon indicates inheritance
    {
        public int TrackingNumber { get; set; }

        public override string ToString() //override = not using implementation of parent, using our own method 
        {
            return $" {base.ToString()} - Tracking Number: {TrackingNumber}"; // "base" = calling the tostring method from the parent class
                   //  ^^ RE-USING CODE 
        }
    }
}
