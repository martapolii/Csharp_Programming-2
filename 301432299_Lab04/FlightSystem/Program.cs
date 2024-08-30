namespace FlightSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the flight class with user input:
          
            // 1. ask for flight number:
            Console.Write("Please enter the Flight Number: ");
            string flightNumber = Console.ReadLine();

            //2. ask for number of available seats:
            Console.Write("Please enter the number of available seats: ");
            int availableSeats = 0;
            try
            {
                 availableSeats = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Invalid entry. Please try again.");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }

            //3. Create an instance of the flight class:
            Flight myFlight = new Flight(flightNumber, availableSeats);

            Console.WriteLine();


            // Allow the user to Book a Flight and Check the Flight Status: 
            //calling the BOOKING method:

            //1. ask user how many seats they want to book: 
            Console.Write("Please enter the number of seats you would like to book: ");
            int numSeats = 0;
            try
            {
                numSeats = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error. Invalid entry. Please try again.");

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a valid number.");
            }

               //2. ask user to enter their name:
            Console.Write("Please enter your name: ");
            string customerName = Console.ReadLine();

               //3.Call the booking method with the captured values as arguments:
            myFlight.Booking(numSeats, customerName);


            //calling the CHECKFLIGHTSTATUS method:

            //1. ask the user to enter their flight number:
            Console.WriteLine();
            Console.Write("Please enter your flight number: ");
            string queryFlightNumber = Console.ReadLine();

            //2. customer name already captured above.
            //3. call the 'CheckFlightStatus' method and pass the captured values as arguments:
            myFlight.CheckFlightStatus(queryFlightNumber, customerName);









        }
    }
}
