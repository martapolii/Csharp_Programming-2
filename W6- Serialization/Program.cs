using System.Text.Json;

namespace W6__Serialization
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // SAVING TO A FILE:

            //create list:
            List<Course> myCourses = new List<Course>();

            /*
            //create 5 objects:
            Course c1 = new Course("MATH185",
                "A math class",
                "Discrete Mathematics",
                "Other Maths",
                2);
            Course c2 = new Course("COMP100", "A programming class", "Programming I", "", 1);

            myCourses.Add(c1);
            */

            //OR create new objects right into Add: 

            myCourses.Add(new Course("MATH185",
                "A math class",
                "Discrete Mathematics",
                "Other Maths",
                2));
            myCourses.Add(new Course("COMP100", 
                "A programming class", 
                "Programming I", 
                "",
                1));
            myCourses.Add(new Course("PYTH100", 
                "A python programming class", 
                "Python 101", 
                "", 
                1));
            myCourses.Add(new Course("COMP123", 
                "A python programming class", 
                "Python 101", 
                "", 
                1));
            myCourses.Add(new Course("PYTH200", 
                "A python programming class", 
                "Python 102", 
                "", 
                2));

            SaveCourses("ListOfCourses.json", myCourses);

            List<Course> mySavedCourse = ReadCourses("ListOfCourses.json");

            foreach (Course course in mySavedCourse)
            {
                Console.WriteLine(course.Name);
            }


        }
        // SERIALIZATION
        // Create a method that will JSON serialize each course and save them in a file: 
        public static void SaveCourses(string fileName, List<Course> listOfCourses)
        {
            // first need to write to file
            StreamWriter writer = new StreamWriter(fileName);

            // need to save each course -> loop: 
            foreach (Course c in listOfCourses)
            {
                //1st need to serialize course object
                string courseJson = JsonSerializer.Serialize(c);

                //create the file, write to it
                writer.WriteLine(courseJson);
                Console.WriteLine(courseJson);

            }
            writer.Close(); //always close you file!
        }

        // DESERIALIZATION
        public static List<Course> ReadCourses(string fileName)
        {
            List<Course> list = new List<Course>();

            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();

            while (line != null)
            {
                Course c = JsonSerializer.Deserialize<Course>(line); // have to specify which class to deserialize to

                list.Add(c); //add to the list

                line = reader.ReadLine(); // read the next line
            }

            reader.Close();

            return list;
        }

    }
}
