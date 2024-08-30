using System.Buffers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // 1. Create four objects:
            Pet cat = new Pet("Mia", 15, "Senior Tabby", "no one", true);
            Pet dog = new Pet("Myla", 4, "Border Collie", "Marta", true);
            Pet axolotl = new Pet("Turbo", 4, "An aquatic salamander");
            Pet dog2 = new Pet("Aspen", 4, "Rottweiler", "no one", true);



          // 2. Create a list to store all the above objects: 
            List<Pet> pets = new List<Pet>();
            pets.Add(cat);
            pets.Add(dog);
            pets.Add(axolotl);
            pets.Add(dog2);

          // 3. Use some of the methods on some of the objects:
            Console.WriteLine("Q3. Using some of the methods on some of the objects:");

            // Describes the 'cat' object:
            Console.WriteLine(cat.ToString());

            // Changes the owner of the axolotl from "no one" to "Marta"
            axolotl.SetOwner("Marta");
            Console.WriteLine(axolotl.ToString());

            // Changes the default property for IsHouseTrained from false to true:
            axolotl.Train();
            Console.WriteLine(axolotl.ToString());

          // 4. Create a looping statement to display all the objects in the collection:
            Console.WriteLine();
            Console.WriteLine("Q4. A looping statement that displays all the objects in the collection:");

            foreach (Pet pet in pets)
                {
                Console.WriteLine(pet.ToString());   // ** ToString = default method associated with our object. c# will call it behind the scenes if we don't specify it. is optional to be placed.
                }

            //5. Prompt the user for an Owners name and then dispay only the pets belonging to that particular person: 
            Console.WriteLine();
            Console.WriteLine("Q5. Prompting the user for a name and displaying only the pets belonging to a particular person:");

            Console.WriteLine("Enter the name of an owner:");
            string name = Console.ReadLine(); // need to assign user input to a varible, and then comapre that variable to the values stored in the owner property of the objects: 

            foreach (Pet pet in pets)
            {
                if (name == pet.owner)
                {
                    Console.WriteLine(pet);
                }
            }
        }
    }
}
