using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk8_Inheritance
{
    internal class Letter //: Object  (object class inheritance is implied so unecessary here) 
    {
        public string RecepientName { get; set; }
        public string DateMailed { get; set; }

        public override string ToString() //override = not using implementation of parent, using our own method 
        {
            return $" {GetType()} - Name: {RecepientName} - Date {DateMailed}";
        }
    }
}
