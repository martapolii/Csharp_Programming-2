using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9__Interfaces
{
    internal class Patient : IRecoverable
    {
        public void Recover()
        {
            Console.WriteLine("I am getting better");
        }
    }
}
