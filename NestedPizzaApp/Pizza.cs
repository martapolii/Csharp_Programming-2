using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedPizzaApp
{
    internal class Pizza
    {
        public string Name { get; set; }
        public int NumberOfToppings { get; set; }
        public Topping[] Toppings{ get; set; }


        // nested class AllToppings
        public class Topping
        {
            public string Name { get; set; }

        }

        // constructor
        public Pizza(string name, int numberOfToppings)
        {
            Name = name;
            NumberOfToppings = numberOfToppings;
            Toppings = new Topping[numberOfToppings];
        }

        // destructor
        ~Pizza()
        {
            Console.WriteLine("Pizza: {0} - How many topping? {1}",
                Name, NumberOfToppings);
        }
        
    }
}
