using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk03_AstronautApp
{
    internal class Astronaut
    { // FIELDS
        private static int count = 0; 
        private static int max = 5;

        // AUTO-IMPLEMENTED PROPERTIES
            // used when there are no fields
        public string Name { get; }

        public string Nationality { get; } // setter absent
       
        

        // CONSTRUCTOR:
        private Astronaut(string name, string nationality)
        {
            Name = name; // can change READ ONLY property values inside the constructor of a class
            Nationality = nationality;
        }
        // since we created our own constructor, deafukt no longer exists, have to explicitly call it below


        // METHODS:
        public static Astronaut CreateAstronaut(string name, string nationality)
        {
            if (count < max)
            {
                Astronaut a = new Astronaut(name, nationality);
                count++;
                return a;
            }
            else
            {
                return null; // null = absence of an object
            }
        }

        public override string ToString()
        {
            return $"Astronaut Name: {Name} - Nationality: {Nationality}";
        }

        // Method to change max so some objets can be made 
        public static void SetMax(int max)
        {
            // max = max;  <- wont work because static member. need to use name of class
            Astronaut.max = max; // *** in static methods use class name instead of .this ***
        }
    }
}
