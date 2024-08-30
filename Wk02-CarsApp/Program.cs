namespace Wk02_CarsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a class called car in another file (Add class to project)
            // can declare a new object related to this class here:
            //Car c = new Car();
            //c.year = 2007; // <- error bc inaccessible (bc private field)

            Car c = new Car(2006, "Toyota", "Corolla", 26_000, true); // 'Car();' is a CONSTRUCTOR of Car
                           // now we HAVE to use constructor, which expects 5 arguments

            Console.WriteLine(c.ToString()); // this line will print namespace + class 
            //ToString is coming from the object parent class 

            // Creating more cars:
            Car a = new Car(2024, "Rocketship", "NASA", 300_000_000, true);
            a.Year = 2016;
            Console.WriteLine(a.ToString());

            Console.WriteLine(a.Year);

            Car b = new Car(2000, "Mazda", "Company", 3000, false);
            Console.WriteLine(b.ToString());

            Car d = new Car(1998, "Challenger", "Ford", 50_000, true);
            Console.WriteLine(d.ToString());

            Car e = new Car(2000, "Porsche", "idkCantAfford", 600_000_000_000, true);
            Console.WriteLine(e.ToString());

            // LISTS

            //declare
            List<Car> cars = new List<Car>();

            //initialize
            cars.Add(c);
            cars.Add(a);
            cars.Add(b);
            cars.Add(d);
            cars.Add(e);

            foreach (Car myCar in cars)
            {
                Console.WriteLine(myCar.ToString());
            }

        }
    }
}
