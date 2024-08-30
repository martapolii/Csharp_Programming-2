using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Marta Polishchuk
 * 301432299
 * COMP123 SEC 402.
 * Assignment 2.
 */


namespace Lab02
{
    //Pet Class: 
    internal class Pet
    {
     //No fields for this particular class:

     //Creating auto-implemented properties (since there are no fields):
        // Syntax: [Public/Private + data type + property name. Then the body (in curly braces): {get; set}]

        public string name { get; }
        public string owner { get; private set; }
        public int age { get; }
        public string description { get; }
        public bool isHouseTrained { get; private set; }


        //Constructor:
  
        public Pet(string name, int age, string description, string owner = "no one", bool isHouseTrained = false) //default parameters are listed at the end. 
        {
            this.name = name;
            this.age = age;
            this.description = description;
            this.owner = owner;
            this.isHouseTrained = isHouseTrained;   
        }

      //Creating Methods to make sense of the output:

        //1st method: creates a string that fully describes the object:
        public override string ToString()
        {
            return $"Name: {name} - Age: {age} - Description: {description} - Owner: {owner} - Is House Trained? {isHouseTrained}.";
        }

        //2nd method: assigns the argument to the appropriate property:
        public void SetOwner(string owner)
        {
            this.owner = owner;
        }

        //3rd method: sets the property ISHouseTrained to true :
        public void Train()
        {
            this.isHouseTrained = true;
        }
    }
}
