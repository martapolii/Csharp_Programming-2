using System.Xml.Schema;

namespace CarDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2 car objects before incrementation:
            Console.WriteLine("Before incrementation:");
            Car c1 = new Car("Toyota"); //object created using the constructor that only takes one argument, so km/L will be set to the default (15)
            Car c2 = new Car("Honda", 18.0); //object created using the constructor that takes 2 arguments 
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();


            // after incrementation: 
            c1++; // behvaiour for increment operator defined by overloading the operator 
            c2++;
            Console.WriteLine("After incrementation:");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

        }
    }
}
