using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk12__Linq
{
    class Person
    {
        public string Name { get; set; }
        public double Asset { get; set; }
        public bool InTech { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return string.Format($"{Age} {(InTech ? "In Tech" : "Not in Tech")} {Asset,4}B {Country.Substring(0, 2).ToUpper()} {Name}");
        }

    }

}
