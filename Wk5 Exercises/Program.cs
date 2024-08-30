using System.Linq.Expressions;

namespace Wk5__Exercises
{
    //Subscription Exception Test
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   
         //declare array first

            double[] array = { 20.6, 13.2, 66.0, 54.8, 4.5, 1.7, 90.2, 8.4, 23.5, 89.4 };

         //prompt

         Console.WriteLine("Please enter a position value from 0 to 9:");
         //collect the input

         int position = int.Parse(Console.ReadLine());

        //print a number

         Console.WriteLine($"The number in position {position} is {array[position]}");
           */

            //Next, build loop that prompt the user: 

            double[] array = { 20.6, 13.2, 66.0, 54.8, 4.5, 1.7, 90.2, 8.4, 23.5, 89.4 };

            int position = 0;

            //try b lock surrounds loop

            try
            {
                while (position != 99)
                {
                    Console.WriteLine("Please enter a position value from 0 to 9 or 99 to exit:");

                    position = Convert.ToInt32(Console.ReadLine());
                    if (position != 99)
                    {
                        Console.WriteLine($"The number in position {position} is {array[position]}.");
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("The position doesn't exist!");
            }
        }
    }

    
}
