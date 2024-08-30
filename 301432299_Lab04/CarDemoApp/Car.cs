using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
/* Marta Polishchuk
 * 301432299
 * COMP123 SEC402
 * Assignment 4
 */

namespace CarDemoApp
{
    internal class Car
    {
        // 2 properties:
        public string Model { get; set; }

        public double KilometersPerLitre { get; set; }

        // 2 overloaded constructors: 
        public Car(string model, double kilometersPerLitre) // this constructor makes the properties 'accessible'
        {
            Model = model;
            KilometersPerLitre = kilometersPerLitre;
        }

        public Car(string model)
        {
            Model = model;
            KilometersPerLitre = 15; // presets a value for km/L
        }

        public override string ToString() // added a ToString to display the output
        {
            return $"Car model: {Model}. Gas intake: {KilometersPerLitre} km/L."; 
        }
        
        // overloaded ++ operator:
        public static Car operator ++(Car car)
        {
            string model = car.Model; // retrieve the model of the object, do not change it
            double kilometersPerLitre = car.KilometersPerLitre; // retrieve the km/L value
            kilometersPerLitre++; //increment this value

            return new Car(model, kilometersPerLitre); // return the car object with the same model value but incremented km/L 
        }
    }
}
