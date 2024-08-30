namespace Wk03_AstronautApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a list of astronauts (objects):

            List<Astronaut> astronauts = new List<Astronaut>();
            Astronaut a;

            a = Astronaut.CreateAstronaut("Yuri Gagarin", "Russian");
            if (a != null)      // 1 // if a is different then null, object created successfully
                astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Alan Shepard", "American");
            if (a != null)     // 2
                astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Virgil Grissom", "American");
            if (a != null)   // 3
                astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Gherman Titov", "Russian");
            if (a != null)      // 4
                astronauts.Add(a);

            a = Astronaut.CreateAstronaut("John Glenn", "American");
            if (a != null)       // 5
                astronauts.Add(a);

            a = Astronaut.CreateAstronaut("Scott Carpenter", "American");
            if (a != null)  // 6  // not going to work because there is NO MORE SPACE (max is 5)
                astronauts.Add(a);


            //only 5 astronauts are created - this loop prints all the objects (5 astronauts)
            Console.WriteLine("Only 5 astronauts were created");
            int count = 1;
            foreach (var astronaut in astronauts)
            {
                Console.WriteLine($"{count++} {astronaut.ToString()}");
            }

            
            Console.WriteLine("Now the 6th astronaut will be created");
            Astronaut.SetMax(6);
            astronauts.Add(Astronaut.CreateAstronaut("Scott Carpenter", "American"));   // 6
            //now 6 astronaut created
            count = 1;
            foreach (var astronaut in astronauts)
            {
               Console.WriteLine($"{count++} {astronaut.ToString()}");
            }




        }
    }
}
