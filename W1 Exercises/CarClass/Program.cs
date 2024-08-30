namespace CarClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create 4 cars. call constructor with 4 or 5 parameters.

            Car car1 = new Car(1998, "Toyota", "Model 7", 20000);
            Console.WriteLine(car1);
            Car car2 = new Car(2024, "Tesla", "X", 80000, false);
            Console.WriteLine(car2);
            Car car3 = new Car(2020, "Tesla", "Y", 120000, true);
            Console.WriteLine(car3);

        }
    }
}
