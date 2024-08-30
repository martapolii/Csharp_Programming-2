namespace MedalAppEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Harness:
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);

            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            //print the updated m2
            Console.WriteLine(m2);

            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));

            int counter = 1;
            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            foreach (Medal aMedal in medals)
            {
                Console.WriteLine($"{counter}. {aMedal.Color}");
                counter++;
            }

            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            foreach (Medal name in medals)
            {
                Console.WriteLine($"{counter}. {name.Name}");
                counter++;   
            }

            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");

            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");

            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");

            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");

            //saving all the medal to file Medals.txt
            Console.WriteLine("\n\nSaving to file");



        }
    }
}
