using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Shape
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(double width, double height)
            :base (width, height)
        {
        }

        //Method
        public override double CalculateSurface()
        {
            double surface = 0;
            surface = (width * height) / 2;
            return surface;
        }
    }
}
