using System.Security.Cryptography;

namespace Wk11__Collections_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creating a list
            //List<Student> students = new List<Student>();
            
            //creating a dictionary
 //           Dictionary<string, Student> students = new Dictionary<string, Student>();
                // key = name, so string, and value = object, so student 
   
            // Adding an entry to the dictionary
/*
              //1.a) initializing a new object 
            Student s1 = new Student();
            s1.Name = "John";
            s1.Gpa = 3.2;
            s1.NumberOfCourses = 5;

            //1.b)
            students.Add(s1.Name, s1);
            
*/

            //2. or declare, initialize and populate dictionary in one go/ add multiple pairs: 
            Dictionary<string, Student> students = new Dictionary<string, Student>
            {
                { "sathi", new Student{ Name = "Sathi Akter", NumberOfCourses= 5, Gpa = 3.8 } },
                { "daniel", new Student{ Name = "Daniel Ross", NumberOfCourses= 6, Gpa = 3.9 } },
                { "reuben", new Student{ Name = "Reuebn Cserepka", NumberOfCourses= 5, Gpa = 4.0 } },
                { "devansh", new Student{ Name = "Devansh Shah", NumberOfCourses= 5, Gpa = 4.1 } },
                { "ming", new Student{ Name = "Ming Zheng", NumberOfCourses= 6, Gpa = 3.9 } },
                { "sanjib", new Student{ Name = "Sanjib Saha", NumberOfCourses= 5, Gpa = 4.0 } }
            };

            //3. or can  add a single pair/make the object within the Add() method: 
            students.Add("Marta", new Student
            {
                Name = "Marta",
                Gpa = 3.2,
                NumberOfCourses = 5
            });
    
            //check the existence of key
            string key = "sahti";
            if (students.ContainsKey(key))
                Console.WriteLine($"{key} is present");
            else 
                Console.WriteLine($"{key} is not present");

            //retrieving a value from a key
            Console.WriteLine(students["daniel"]);

            //changing a value for key sathi
            key = "sathi";
            Console.WriteLine($"\nReplacing value {key}");
            students[key] = new Student { Name = "Narendra", Gpa = 3.0, NumberOfCourses = 2 };

            //removing a single pair
            Console.WriteLine($"\nRemoving {key}");
            students.Remove(key);

            //Looping - foreach
            Console.WriteLine("\nAll values");
            foreach (Student s in students.Values)
            {
                Console.WriteLine($"{s}");
            }

            //all keys    
            Console.WriteLine("\nAll keys");
            foreach (string k in students.Keys)
            {
                Console.WriteLine($"{k}");
            }

            //all items pairs
            Console.WriteLine("\nAll key-value pairs");
            foreach (KeyValuePair<string, Student> stud in students)
            {
                Console.WriteLine($"{stud.Key} - {stud.Value}");
            }

        }
    }
}
