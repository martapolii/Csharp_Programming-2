// Marta Polishchuk
// 301432299
// COMP123 Sec 402
// Assignment 5

using System.Diagnostics;

namespace _301432299_Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Division with no handling:");
            DivisionNoHandling();
            
            //Console.WriteLine("2. Division with exception handling:");
            //DivisionWithExceptionHandling();
            
            //Console.WriteLine("3. Division with exception handling and more info:");
            //DivisionWithExceptionHandlingMoreInfo();
           
            //Console.WriteLine("4.Division with exception handling and throwing an exception");
            //DivisionWithExceptionHandlingThrow();

            //Console.WriteLine("5. Generating an exception:");
            //GeneratingException();

            //Console.WriteLine("6. Handling a random exception:");
            //HandlingRandomException();

        }

        //METHODS:

        
        static int Division(int top, int bottom) => top / bottom;

        //1
        static void DivisionNoHandling()
        {
            Division(1, 0);
        }

        //2
        static void DivisionWithExceptionHandling()
        {
            try
            {
                Division(1, 0);
            }
            catch
            {
                Console.WriteLine("");
            }

        }

        //3
        static void DivisionWithExceptionHandlingMoreInfo()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        //4
        static void DivisionWithExceptionHandlingThrow()
        {
            try
            {
                Division(1, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            throw new Exception("This is a new exception");

        }

        //5
        static void GeneratingException()
        {
            throw new Exception("This is a new exception.");
        }

        //6
        static void HandlingRandomException()
        {
            try
            {
                GeneratingRandomException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception: The index is out of range of the array or collection.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference Exception: value null was found where an instance of an object was required.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Operation Exception: Object is in a state that makes the calling method illegal/invalid.");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic Exception:This mathematical operation is not possible.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception: This value is not in an appropriate format.");
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("(Invalid Cast Exception: The attempted conversion of types is not legal.");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Out Of Memory Exception: There is not enough memory to execute this command"); 
            }
        }

        //7
        static void GeneratingRandomException()
        {
            int exceptionType = new Random().Next() % 7;

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
