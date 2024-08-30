using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9__Interfaces
{
    public interface IRecoverable
    {
         void Recover(); // by default public and abstract
        //no body 

        // any class that implements this interface MUST also implement this member
    }
}
