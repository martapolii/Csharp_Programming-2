using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalAppEnum
{

    //declare an ENUM
    enum MedalColor{Bronze, Silver, Gold};
    internal class Medal
    {
        // properties - all public and read-only (absent setter)
        public string Name { get; }
        public string TheEvent { get; }
        public MedalColor Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }

        //constructor
        public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }
        
        public override string ToString()
        {
            string record ="";
            if (IsRecord == true)
            {
                record = "(R)";
            }
            else
            {
                record = "";
            }
            return $"{Year} - {TheEvent}{record} {Name}({Color})";
        }
        

        // OR use conditional operator instead of if-else statement:
        /*public override string ToString()
        {
            return $"{Year} - {TheEvent}{(IsRecord ? "(R)" : "")} {Name}({Color})";
        }
        */


    }
}
