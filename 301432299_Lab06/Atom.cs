using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _301432299_Lab06
{
    internal class Atom
    {
        // properties:
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int Proton { get; set; }
        public int Neutron { get; set; }
        public double Weight { get; set; }

        // constructors: 
        public Atom() //default constructor for serialization
        {
        }
        public Atom(string name, int proton, int neutron, double weight, string symbol )
        {
            Name = name;
            Proton = proton;
            Neutron = neutron;
            Weight = weight;
            Symbol = symbol;
        }

        // methods:
        public static Atom Parse(string objectData)
        {
         
            string[] atomDescription = objectData.Split(' '); //split up the string, using spaces as seperator characters, into an array 

            if (atomDescription.Length != 5) // if the argument is not exactly 5 parts then an error is thrown:
            {
                throw new Exception("Must list exactly 5 atom properties");
            }

            string name = atomDescription[0]; // have to crate variables to store the .Split() strings from the array (by index number)
            int proton = int.Parse(atomDescription[1]);
            int neutron = int.Parse(atomDescription[2]);
            double weight = double.Parse(atomDescription[3]);
            string symbol = atomDescription[4];

            return new Atom(name, proton, neutron, weight, symbol); // return new Atom object
        }         
        
        public override string ToString()
        {
            return $"Atom Name: {Name} | Symbol: {Symbol} | Protons: {Proton} | Neutrons: {Neutron} | Weight: {Weight} |";
        }

    }
}




/* first attempt for Parse method:

if (atomDescription.Length != 5) // if the argument is not exactly 5 parts then an error is thrown:
{
    throw new Exception("Must list exactly 5 atom properties");
}
 else
            {
                int indexNumber = 1; // a counter to loop through the array 

                foreach (string property in atomDescription)  // for each string in the array, assign it to the appropriate object property 
                {
                    do
                    {
                        switch (indexNumber)
                        {
                            case 1:
                                Atom name = Atom.Parse(property); // need to convert string to type Atom 
                                break;
                            case 2:
                                Atom symbol = Atom.Parse(property);
                                break;
                            case 3:
                                Atom proton = Atom.Parse(property);
                                break;
                            case 4:
                                Atom neutron = Atom.Parse(property);
                                break;
                            case 5:
                                Atom weight = Atom.Parse(property);

                                //creating a new object
                                return new Atom(name, symbol, proton, neutron, weight); 

                                break;
                        }

                        indexNumber++;
                    } while (indexNumber <= 5);

                }*/