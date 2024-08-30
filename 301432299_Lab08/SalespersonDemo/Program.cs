namespace SalespersonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiating objects from RealEstateSalesperson and GirlsScout classes:
            RealEstateSalesperson realtor1 = new RealEstateSalesperson("Sam", "McDadi", 0.05); //(this is a real Mississauga Realtor)
            RealEstateSalesperson realtor2 = new RealEstateSalesperson("Karen", "Brandi", 0.07);

            GirlScout scout1 = new GirlScout("Angela", "Box");
            GirlScout scout2 = new GirlScout("Maxine", "Quill");

            // Demonstrating SaleSpeech method:
            realtor1.SalesSpeech();
            realtor2.SalesSpeech();

            scout1.SalesSpeech();
            scout2.SalesSpeech();

            Console.ReadKey();
            Console.WriteLine();

            // Demonstrating the MakeSale Method
            realtor1.MakeSale(1000000);
            DisplayInfo(realtor1);
            realtor2.MakeSale(200000);
            DisplayInfo(realtor2);

            scout1.MakeSale(5);
            DisplayInfo(scout1);
            scout2.MakeSale(8);
            DisplayInfo(scout2);

            Console.ReadKey();
            Console.WriteLine();

            // Adding on to the sales and displaying the updated info:
            realtor1.MakeSale(2000000); //total value sold is now 3 million and total commission has increased accordingly.
            DisplayInfo(realtor1);

            realtor2.MakeSale(500000); //total value sold is now 700,000 and total commission has increased accordingly
            DisplayInfo(realtor2);

            scout1.MakeSale(1); // instead of 5 boxes, it is now 6
            DisplayInfo(scout1);

            scout2.MakeSale(10); // instead of 8 boxes, it is now 18
            DisplayInfo(scout2);


        }

        // method that displays all the info for each object after using the MakeSale method, with a personalized message depending on what type of object it is:
        public static void DisplayInfo(SalesPerson person) //takes a generic SalesPerson object as the argument
        {
            //used the "is" operator (week 9 Interfaces module) to check the type of object (which class it is from), if it matches then a customized message displays:

            if (person is RealEstateSalesperson realtor) 
            {
                Console.WriteLine($"I am {person.ToString()}, and I sold {realtor.TotalValueSold:C} worth of homes this year and made a total commission of {realtor.TotalCommissionEarned:C}.");
                Console.WriteLine();
            }
            else if (person is GirlScout scout)
            {
                Console.WriteLine($"I am {person.ToString()}, and I sold {scout.NumberOfBoxesSold} boxes of Girl Scout cookies this season.");
                Console.WriteLine();
            }
        }
    }
}
