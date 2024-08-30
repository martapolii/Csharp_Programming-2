using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
//Marta Polishchuk
//301432299
namespace FlightSystem
{
    internal class Flight
    {
        //Fields
        private string flightNumber;
        private int availableSeats;

        //Properties
        public string FlightNumber 
        { 
            get
            {
                return flightNumber;
            }

            set
            {
                flightNumber = value;
            }
        }
        public int AvailableSeats 
        {
            get
            {
                return availableSeats;
            }

            set
            {
                availableSeats = value;
            }
        
        }

        //Constructor
        public Flight(string flightNumber, int availableSeats)
        {
            this.flightNumber = flightNumber;
            this.availableSeats = availableSeats;
        }

        //Methods
        public void Booking(int numSeats, string customerName)
        {
            /* needs to check number of requested seats
             * - if available: - reduce 'availableSeats' by 'numSeats'
             *                 - print: Booking successfull + customer name & flight #
             * - if not: print: booking could not be completed due to insufficient seats 
             * Method: an if-else statement seems most appropriate here   
             */
            if (numSeats <= availableSeats)
            {
                AvailableSeats -= numSeats;
                Console.WriteLine($"Booking was successful for customer '{customerName}' with flight number: {flightNumber}.");
            }
            else
            {
                Console.WriteLine("Booking could not be completed due to insufficient seats.");
            } 
        }

        public bool CheckFlightStatus(string queryFlightNumber, string customerName)
        {
            /* check if queryFlightNumber matches the flights flightNumber 
             * True = print availableSeats + thank you customer name
             * False = flight number is incorrect
             * Method: sounds like a job for the ternary (conditional) operator
             * syntax:     condition ? true : false << too long. doing if-else instead.
             */

            if (queryFlightNumber == flightNumber)
            { 
                Console.WriteLine($"Number of available seats is {availableSeats}. Thankyou, {customerName}, for choosing this airline.");
                return true;
            }
            else
            {
                Console.WriteLine("The flight number entered is incorrect.");
                return false;
            }
        }

















    }
}
