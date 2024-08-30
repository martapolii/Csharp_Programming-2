namespace Wk12__Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Show all non-US citizens
            var nonUS = persons.Where(p => p.Country != "US");
            // only return the people where the country is different than the US 
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Show all non-US citizens");
            Console.WriteLine("---------------------------");
            foreach (var person in nonUS)
                Console.WriteLine(person);

            //2. Show only the name of all US citizens 
            var usPeople = persons
                .Where(p => p.Country == "US")
                .Select(p => p.Name);
            //Select filters through the results of there Where query
            // can concatenate many queries together
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("2. Show only the name of all US citizens ");
            Console.WriteLine("-----------------------------------------");
            foreach (string name in usPeople)
                Console.WriteLine(name);

            //3. Show all tech billionaires. 
            var techPeople = persons
                .Where(p => p.InTech == true);
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("3. Show all tech billionaires.  ");
            Console.WriteLine("--------------------------------");
            foreach (var person in techPeople)
                Console.WriteLine(person);

            //4. Sort the collection by name.
            var sortedByName = persons
                   .OrderBy(p => p.Name) // can also do .OrderByDescending.
                   .ThenBy(p => p.Age);
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("4. Sort the collection by name. ");
            Console.WriteLine("--------------------------------");
            foreach (var person in sortedByName)
                Console.WriteLine(person);

            //5. Group the collection by tech.    // have other methods to group/aggregate by 
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("5. Group the collection by tech.");
            Console.WriteLine("--------------------------------");
            var groupedData = persons.GroupBy(p => p.InTech);
            foreach (var group in groupedData)
                Console.WriteLine($"{(group.Key == true ? "In Tech" : "Not in Tech")} - {group.Count()}");


            //6. Show the longest name.


            //7. Show the name with the most vowels. 



        }
        static List<Person> persons = new List<Person>() //static, so member of Program class
            { // created a list and added objects to it in one go
              new Person(){ Age = 72, Asset = 7.0, Country="South Africa", InTech=false, Name="Nicky Oppenheimer"},
              new Person(){ Age = 67, Asset = 7.6, Country="India", InTech=true, Name="Savitri Jindal"},
              new Person(){ Age = 81, Asset = 3.1, Country="India", InTech=true, Name="Indu Jain"},
              new Person(){ Age = 70, Asset = 2.5, Country="India", InTech=true, Name="Vinod Gupta"},
              new Person(){ Age = 77, Asset = 27.0, Country = "US",InTech = true,Name = "Jacqueline Mars"},
              new Person(){ Age = 76, Asset = 25.2, Country = "Italy", InTech = true, Name = "Maria Franca Fissolo"},
              new Person(){ Age = 55, Asset = 20.4, Country = "Germany", InTech = true, Name = "Susanne Klatten"},
              new Person(){ Age = 53, Asset = 20.0, Country = "US",InTech = true,Name = "Laurene Jobs"},
              new Person(){ Age = 60, Asset = 12.5, Country = "Nigeria", InTech=false, Name="Aliko Dangote" },
              new Person(){ Age = 76, Asset = 10.9, Country = "Ethiopia", InTech=false, Name="Mohammed Al Amoudi"},
              new Person(){ Age = 60, Asset = 30.7, Country = "Canada", InTech=false, Name="David Thomson" },
              new Person(){ Age = 76, Asset = 11.4, Country = "Canada", InTech=false, Name="Galen Weston"},
              new Person(){ Age = 60, Asset = 22.3, Country = "India", InTech=false, Name="Mukesh Ambani"},
              new Person(){ Age = 50, Asset = 17.5, Country = "India", InTech=false, Name="Dilip Shanghvi"},
              new Person(){ Age = 83, Asset = 30.4, Country = "US", InTech=false, Name="Sheldon Adelson"},
              new Person(){ Age = 78, Asset = 30.0, Country = "Brazil", InTech=false, Name="Jorge Lemann"},
              new Person(){ Age = 62, Asset = 18.4, Country = "Russia", InTech=false, Name="Leonid Mikhelson"},
              new Person(){ Age = 51, Asset = 17.5, Country = "Russia", InTech=false, Name="Alexey Mordashov"},
              new Person(){ Age = 89, Asset = 31.2, Country = "Hong Kong", InTech=false, Name="Li Ka-shing"},
              new Person(){ Age = 62, Asset = 31.2, Country = "China", InTech=false, Name="Wang Jianlin"},
              new Person(){ Age = 67, Asset = 33.8, Country = "US", InTech=true, Name="Alice Walton" },
              new Person(){ Age = 60, Asset = 34.0, Country = "US", InTech=false, Name="Jim Walton"},
              new Person(){ Age = 72, Asset = 34.1, Country = "US", InTech=false, Name="Rob Walton"},
              new Person(){ Age = 94, Asset = 39.5, Country = "France", InTech=true, Name="Liliane Bettencourt"},
              new Person(){ Age = 43, Asset = 39.8, Country = "US", InTech=true, Name="Sergey Brin"},
              new Person(){ Age = 43, Asset = 39.6, Country = "US", InTech=true, Name="Larry Page"},
              new Person(){ Age = 68, Asset = 41.5, Country = "France", InTech=false, Name="Bernard Arnault"},
              new Person(){ Age = 75, Asset = 47.5, Country = "US", InTech=false, Name="Michael Bloomberg"},
              new Person(){ Age = 77, Asset = 48.3, Country = "US", InTech=false, Name="David Koch"},
              new Person(){ Age = 81, Asset = 48.3, Country = "US", InTech=false, Name="Charles Koch"},
              new Person(){ Age = 72, Asset = 52.2, Country = "US", InTech=true, Name="Larry Ellison"},
              new Person(){ Age = 77, Asset = 54.5, Country = "Mexico", InTech=false, Name="Carlos Slim Helu"},
              new Person(){ Age = 33, Asset = 56.0, Country = "US", InTech=true, Name="Mark Zuckerberg"},
              new Person(){ Age = 81, Asset = 71.3, Country = "Spain", InTech=false, Name="Amancio Ortega"},
              new Person(){ Age = 53, Asset = 72.8, Country = "US", InTech=false, Name="Jeff Bezos" },
              new Person(){ Age = 85, Asset = 75.6, Country = "US", InTech=false, Name="Warren Buffet" },
              new Person(){ Age = 60, Asset = 86.0, Country = "US", InTech=true, Name="Bill Gates"}
            };

    }
}
