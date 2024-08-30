using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W9__Polymorphism
{
    internal class Triangle: GeometricFigure
    {
        public override void ComputeArea()
        {
            area = Height/2 * Width;
        }
    }
}
