using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TOPIC: WK 6 - SERIALIZATION
/* - converting a complex object into a series of bytes (a string)
 * - strings are easier to store, transmit 
 * - can put structure in a string
 * - will have a complex object and a serialized object 
 * - something needs to indicate what string is associated with that properties - many formats for this 
 * 
 * - we will use JSON 
 */
namespace W6__Serialization
{
    internal class Course
    {
        //properties:
        public string Code { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Prerequisites { get; set; }
        public int Semester { get; set; }

        // constructor:
        public Course(string code, string description, string name, string prerequisites, int semester)
        {
            Code = code;
            Description = description;
            Name = name;
            Prerequisites = prerequisites;
            Semester = semester; 
        }




    }
}
