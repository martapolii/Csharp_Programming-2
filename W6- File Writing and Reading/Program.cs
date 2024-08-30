namespace W6__File_Writing_and_Reading
{
    internal class Program
    {
// WEEK 6 - TOPIC: FILE Input/Output
        static void Main(string[] args)
        {
            WriteFile();

            ReadFile(); // reads one line at a time. can loop to read more.

        }
    // WRITING TO A FILE
        static void WriteFile()
        {
            //1. save information to a file name 
            string fileName = "my-file.txt";

            //2. create an object that connects with the file (can read or write)
            // to write to the file:
            StreamWriter writer = new StreamWriter(fileName); // always OVERWRITING existing file

            //StreamWriter writer = new StreamWriter(fileName,true); //<- true = APPEND

            //3. Write information to the file:  //these methods are dynamic because have to make an object to use them
            writer.WriteLine("Marta ");
            writer.Write("Polishchuk");

            //* always close file!!
            writer.Close();

            //file can be found in the same folder as the executable - in the bin 

        }
        //READING A FILE:
        static void ReadFile()
        {
            //1. declare file name
            string fileName = "my-file.txt";

            //2. create an object to connect to the file
            StreamReader reader = new StreamReader(fileName);

            string line = reader.ReadLine(); // will return FIRST line of the file 

            // read all lines with a loop until line is equal to null
            while (line != null) 
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

            // also close the file!
            reader.Close();
        }






    }
}
