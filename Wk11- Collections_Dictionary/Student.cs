using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk11__Collections_Dictionary
{
    class Student
    {
        public string Name { get; set; }
        public int NumberOfCourses { get; set; }
        public double Gpa { get; set; }
        public override string ToString()
        {
            return $"{Name} {Gpa:f} {NumberOfCourses}course(s)";
        }
    }
}
