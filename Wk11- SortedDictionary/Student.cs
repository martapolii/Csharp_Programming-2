using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string city;
        private bool isDomestic;
        private string program;
        private int semester;
        private double gpa;
        private string courses;
        // add property
        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            private set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            private set
            {
                lastName = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            private set
            {
                city = value;
            }
        }

        public bool IsDomestic
        {
            get
            {
                return isDomestic;
            }
            private set
            {
                isDomestic = value;
            }
        }

        public string Program
        {
            get
            {
                return program;
            }
            private set
            {
                program = value;
            }
        }

        public int Semester
        {
            get
            {
                return semester;
            }
            private set
            {
                semester = value;
            }
        }

        public double Gpa
        {
            get
            {
                return gpa;
            }
            private set
            {
                gpa = value;
            }
        }

        public string Courses
        {
            get
            {
                return courses;
            }
            private set
            {
                courses = value;
            }
        }
        //add new property to constructor
        public Student(int id, // added here
            string firstName,
            string lastName,
            string city,
            bool isDomestic,
            string program,
            int semester,
            double gpa,
            string courses)
        {
            Id = id; // and here
            FirstName = firstName;
            LastName = lastName;
            City = city;
            IsDomestic = isDomestic;
            Program = program;
            Semester = semester;
            Gpa = gpa;
            Courses = courses;
        }

    }
}
