namespace NestedPizzaApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakePizza();

            Console.ReadKey();
        }


        // method to make pizzas:
        static void MakePizza()
        {
            Pizza myPizza = new Pizza("Margherita", 4);

            myPizza.Toppings[0] = new Pizza.Topping();
            myPizza.Toppings[0].Name = "Cheese";

            myPizza.Toppings[1] = new Pizza.Topping();
            myPizza.Toppings[1].Name = "Tomatoes";

            myPizza.Toppings[2] = new Pizza.Topping();
            myPizza.Toppings[2].Name = "Garlic";

            myPizza.Toppings[3] = new Pizza.Topping();
            myPizza.Toppings[3].Name = "Oregano";

            Console.WriteLine("How many toppings would you like on your pizza?");
            int numberOfToppings = int.Parse(Console.ReadLine());

            foreach (Pizza.Topping topping in myPizza.Toppings)
            {
                Console.WriteLine($" - {topping.Name}");
            }




        }



    }


}
