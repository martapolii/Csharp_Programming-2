using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            //DivisionNoHandling();

            //#2
            //DivisionWithExceptionHandling();

            //#3
            //DivisionWithExceptionHandlingMoreInfo();

            //#4
            //DivisionWithExceptionHandlingThrow();

            //#5
            //GeneratingException();

            //#6
            HandlingRandomException();
        }

        //static int Division(int top, int bottom) => top / bottom;

        static int Division(int top, int bottom)
        {
            return top / bottom;
        }

        //#1
        static void DivisionNoHandling()
        {
            //call the Division method with argument 1 and 0
            //this will terminate your application

            Division(1, 0);
        }

        //#2
        static void DivisionWithExceptionHandling()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and do nothing
            //Your application should not crash

            try
            {
                Division(1, 0);
            }
            catch
            {
            }

            //or

            try
            {
                Division(1, 0);
            }
            catch (DivideByZeroException e)
            {
            }
        }

        //#3
        static void DivisionWithExceptionHandlingMoreInfo()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //your application should not crash
            try
            {
                Division(1, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //#4
        static void DivisionWithExceptionHandlingThrow()
        {
            //call the Division method with argument 1 and 0
            //You will catch the exception and print the associated message
            //You should create and throw a new exception
            //your application will crash

            try
            {
                Division(1, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                //throw e;
                throw new Exception("Here I am throwing again!");
            }
        }

        //#5
        static void GeneratingException()
        {
            //You should create and throw a new exception
            //your application will crash
            throw new Exception("This is my exception!");
        }

        //#6
        static void HandlingRandomException()
        {
            //You should call the method below and catch all the possible exceptions individually and display a sensible output
            //your application will not crash

            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"NullReferenceException: {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"InvalidOperationException: {e.Message}");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine($"ArithmeticException: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"FormatException: {e.Message}");
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"InvalidCastException: {e.Message}");
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine($"OutOfMemoryException: {e.Message}");
            }
        }


        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 6;
            switch (exceptionType)
            {
                case 0:
                    throw new IndexOutOfRangeException();
                case 1:
                    throw new NullReferenceException();
                case 2:
                    throw new InvalidOperationException();
                case 3:
                    throw new ArithmeticException();
                case 4:
                    throw new FormatException();
                case 5:
                    throw new InvalidCastException();
                case 6:
                    throw new OutOfMemoryException();
            }
        }




    }
}
